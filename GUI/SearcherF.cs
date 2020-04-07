﻿using System.Drawing;
using System.Windows.Forms;
using Spawn.Core;

namespace Spawn.GUI
{
    public partial class SearcherF : CustomForm
    {
        public SearcherF()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            MinimumSize = MaximumSize = Size;
            MaximizeBox = false;

            Load += (sender, e) =>
            {
                ImageList imgList = new ImageList();
                for (int i = 0; i < FilesManager.BuildSets.Count; i++)
                {
                    BuildSet set = FilesManager.BuildSets[i];
                    imgList.Images.Add(set.Image);
                }

                listView1.SmallImageList = imgList;
            };


            textBox1.TextChanged += (sender, e) =>
            {
                if (textBox1.Text.Length > 1)
                    SearchByWord(textBox1.Text);
                else if (textBox1.Text.Length == 0)
                    listView1.Items.Clear();
            };

            listView1.MouseDoubleClick += (sender, e) =>
            {
                if (listView1.SelectedIndices.Count == 0 || listView1.SelectedIndices[0] < 0) return;

                ListViewItem item = listView1.GetItemAt(e.X, e.Y);
                if (item?.Tag is BuildingEntry entry)
                {
                    if (!Global.FreeView)
                        Global.FreeView = true;
                    Global.X = entry.Location.X;
                    Global.Y = entry.Location.Y;
                    Global.Facet = entry.Map == 7 ? 0 : entry.Map;
                }
            };

            FormClosing += (sender, e) =>
            {
                if (Global.FreeView)
                    Global.FreeView = false;
            };
        }

        private void SearchByWord(string word)
        {
            listView1.Items.Clear();

            for (int i = 0; i < FilesManager.BuildSets.Count; i++)
            {
                foreach (BuildingEntry entry in FilesManager.BuildSets[i].Entries)
                {
                    if (entry.Description.ToLower().Contains(word))
                    {
                        ListViewItem item = new ListViewItem(entry.Description);
                        item.SubItems.Add(entry.Location.ToString());
                        item.SubItems.Add(entry.Map.ToString());
                        item.Tag = entry;
                        item.ImageIndex = i;

                        listView1.Items.Add(item);
                    }
                }
            }
        }
    }
}