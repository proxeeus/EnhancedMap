using Spawn.Core;
using Spawn.Core.MapObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultima;

namespace Spawn.GUI
{
    public partial class SpawnEntryWindow : Form
    {
        public BindingList<SpawnObject> Spawns { get; private set; }

        public SpawnObject SelectedSpawn { get; private set; }

        public bool IsMobileListLocked { get; set; }

        public SpawnDefinition GetGUISpawnDefinition()
        {
            var spawnDefinition = new SpawnDefinition();

            spawnDefinition.HomeRange = this.homeRangeTextBox.Text;
            spawnDefinition.MaxTime = this.maxTimeTextBox.Text;
            spawnDefinition.MinTime = this.minTimeTextBox.Text;
            spawnDefinition.NPCCount = this.npcCountTextBox.Text;
            spawnDefinition.SpawnerName = this.spawnNameTextBox.Text;
            spawnDefinition.Team = this.teamTextBox.Text;
            spawnDefinition.MapId = Global.PlayerInstance.Map.ToString();
            spawnDefinition.UniqueSpawn = uniqueSpawnCheckBox.Checked;
            spawnDefinition.BringToHome = bringToHomeCheckBox.Checked;
            
            foreach (var mobile in spawnMobilesListBox.Items) { spawnDefinition.Mobiles.Add(mobile.ToString()); }

            return spawnDefinition;
        }

        public void AddNewSpawnEntry(SpawnObject spawner)
        {
            Spawns.Add(spawner);

            //RefreshUI();
        }

        public void RefreshUI()
        {
            allSpawnsListBox.Refresh();
            allSpawnsListBox.Update();
        }

        public SpawnEntryWindow()
        {
            InitializeComponent();
            InitMobileTypes();
            Spawns = new BindingList<SpawnObject>();
            allSpawnsListBox.DataSource = Spawns;
            

            if (Spawns == null) Spawns = new BindingList<SpawnObject>();
        }

        private void InitMobileTypes()
        {
            var mobilesPath = ConfigurationManager.AppSettings["RunUODir"].ToString();
            var mobilesDirectory = new DirectoryInfo(mobilesPath);

            ListDirectory(mobilesTreeView, mobilesPath);
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(Path.GetFileNameWithoutExtension(file.Name)));
            return directoryNode;
        }

        private void mobilesTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var clickedNode = e.Node;
            if (clickedNode.Nodes.Count > 0) return;
            if(!IsMobileListLocked)
                spawnMobilesListBox.Items.Add(clickedNode.Text);
        }

        private void addMobileTypeButton_Click(object sender, EventArgs e)
        {
            if (!IsMobileListLocked)
                spawnMobilesListBox.Items.Add(mobileTypeNameTextBox.Text);
        }

        private void allSpawnsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsMobileListLocked = true ;
            var selectedSpawner = ((ListBox)sender).SelectedItem as SpawnObject ;
            SelectedSpawn = selectedSpawner;

            if (SelectedSpawn == null) return;
            UpdateUI(SelectedSpawn);

            Global.X = SelectedSpawn.Position.X;
            Global.Y = SelectedSpawn.Position.Y;
        }

        private void UpdateUI(SpawnObject spawnerData)
        {
            if (spawnerData == null) return;
            spawnNameTextBox.Text = spawnerData.SpawnerName;
            npcCountTextBox.Text = spawnerData.NPCCount.ToString();
            minTimeTextBox.Text = spawnerData.MinTime.ToString();
            maxTimeTextBox.Text = spawnerData.MaxTime.ToString();
            teamTextBox.Text = spawnerData.Team.ToString();
            homeRangeTextBox.Text = spawnerData.HomeRange.ToString();
            bringToHomeCheckBox.Checked = spawnerData.BringToHome;
            uniqueSpawnCheckBox.Checked = spawnerData.UniqueSpawn;

            spawnMobilesListBox.DataSource = spawnerData.Mobiles;
        }

        private void allSpawnsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.allSpawnsListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var selectedSpawner = ((ListBox)sender).SelectedItem as SpawnObject;
                SelectedSpawn = selectedSpawner;
                UpdateUI(SelectedSpawn);
                Global.X = SelectedSpawn.Position.X;
                Global.Y = SelectedSpawn.Position.Y;
            }

        }

        private void loadSpawnButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = dialog.Filter = "Map files (*.map)|*.map";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Clear map
                if(Spawns.Count > 0)
                {
                    foreach(var spawn in Spawns)
                    {
                        RenderObjectsManager.RemoveSpawn(spawn);
                    }
                    Spawns.Clear();
                }

                var spawnReader = new SpawnReader();
                spawnReader.MapFileName = dialog.FileName;
                var spawns = spawnReader.LoadSpawns();

                Spawns = spawns;
                allSpawnsListBox.DataSource = Spawns;

                foreach (var spawn in spawns)
                {
                    RenderObjectsManager.AddSpawner(spawn);
                }

                RefreshUI();
            }
        }

        private void saveSpawnButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = saveFileDialog.Filter = "Map files (*.map)|*.map";
            var result = saveFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                var writer = new SpawnWriter(Spawns);
                writer.Save(saveFileDialog.FileName);
            }
        }

        private void deleteSpawnButton_Click(object sender, EventArgs e)
        {
            if (SelectedSpawn == null)
            {
                MessageBox.Show("Please select a valid spawn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RenderObjectsManager.RemoveSpawn(SelectedSpawn);
            Spawns.Remove(SelectedSpawn);
            

        }

        private void GotoSpawnButton_Click(object sender, EventArgs e)
        {
            if (SelectedSpawn == null)
            {
                MessageBox.Show("Please select a valid spawn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var command = string.Format("[go {0} {1}", SelectedSpawn.Position.X, SelectedSpawn.Position.Y);
            Client.SendText(command);
        }

        private void RemoveMobileTypeButton_Click(object sender, EventArgs e)
        {
            if (spawnMobilesListBox.Items == null)
                return;
            if (spawnMobilesListBox.Items.Count == 0)
                return;
            if (spawnMobilesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a type to remove first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsMobileListLocked)
                return;
            if(Spawns == null)
                spawnMobilesListBox.Items.Remove(spawnMobilesListBox.SelectedItem);
            
        }

        private void NewSpawnButton_Click(object sender, EventArgs e)
        {
            if(IsMobileListLocked)
                IsMobileListLocked = false;
            spawnMobilesListBox.DataSource = null;
            spawnMobilesListBox.Items.Clear();
        }

        private void UpdateSelectedSpawn()
        {
            if(SelectedSpawn != null)
            {
                SelectedSpawn.SpawnerName = spawnNameTextBox.Text;
                SelectedSpawn.Team = Convert.ToInt32(teamTextBox.Text);
                SelectedSpawn.UniqueSpawn = uniqueSpawnCheckBox.Checked;
                SelectedSpawn.BringToHome = bringToHomeCheckBox.Checked;
                SelectedSpawn.NPCCount = Convert.ToInt32(npcCountTextBox.Text);
                SelectedSpawn.HomeRange = Convert.ToInt32(homeRangeTextBox.Text);
                SelectedSpawn.MinTime = minTimeTextBox.Text;
                SelectedSpawn.MaxTime = maxTimeTextBox.Text;
                allSpawnsListBox.DataSource = null;
                allSpawnsListBox.DataSource = Spawns;
                RefreshUI();
                //SelectedSpawn.Mobiles.Clear();
                //foreach (var mobile in spawnMobilesListBox.Items)
                //    SelectedSpawn.Mobiles.Add(mobile.ToString());

            }
        }

        private void UniqueSpawnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedSpawn();
        }

        private void BringToHomeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedSpawn();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateSelectedSpawn();
        }
    }
}
