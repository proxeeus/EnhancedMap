namespace Spawn.GUI
{
    partial class SpawnEntryWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mobilesTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.npcCountTextBox = new System.Windows.Forms.TextBox();
            this.homeRangeTextBox = new System.Windows.Forms.TextBox();
            this.minTimeTextBox = new System.Windows.Forms.TextBox();
            this.maxTimeTextBox = new System.Windows.Forms.TextBox();
            this.teamTextBox = new System.Windows.Forms.TextBox();
            this.bringToHomeCheckBox = new System.Windows.Forms.CheckBox();
            this.mobileTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spawnMobilesListBox = new System.Windows.Forms.ListBox();
            this.addMobileTypeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.spawnNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uniqueSpawnCheckBox = new System.Windows.Forms.CheckBox();
            this.allSpawnsListBox = new System.Windows.Forms.ListBox();
            this.loadSpawnButton = new System.Windows.Forms.Button();
            this.saveSpawnButton = new System.Windows.Forms.Button();
            this.deleteSpawnButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mobilesTreeView
            // 
            this.mobilesTreeView.HideSelection = false;
            this.mobilesTreeView.Location = new System.Drawing.Point(12, 12);
            this.mobilesTreeView.Name = "mobilesTreeView";
            this.mobilesTreeView.Size = new System.Drawing.Size(230, 449);
            this.mobilesTreeView.TabIndex = 0;
            this.mobilesTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mobilesTreeView_NodeMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NPC Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Min time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Team:";
            // 
            // npcCountTextBox
            // 
            this.npcCountTextBox.Location = new System.Drawing.Point(127, 39);
            this.npcCountTextBox.Name = "npcCountTextBox";
            this.npcCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.npcCountTextBox.TabIndex = 7;
            this.npcCountTextBox.Text = "1";
            // 
            // homeRangeTextBox
            // 
            this.homeRangeTextBox.Location = new System.Drawing.Point(127, 62);
            this.homeRangeTextBox.Name = "homeRangeTextBox";
            this.homeRangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeRangeTextBox.TabIndex = 8;
            this.homeRangeTextBox.Text = "5";
            // 
            // minTimeTextBox
            // 
            this.minTimeTextBox.Location = new System.Drawing.Point(127, 85);
            this.minTimeTextBox.Name = "minTimeTextBox";
            this.minTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTimeTextBox.TabIndex = 10;
            this.minTimeTextBox.Text = "2.5";
            // 
            // maxTimeTextBox
            // 
            this.maxTimeTextBox.Location = new System.Drawing.Point(127, 107);
            this.maxTimeTextBox.Name = "maxTimeTextBox";
            this.maxTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTimeTextBox.TabIndex = 11;
            this.maxTimeTextBox.Text = "10.0";
            // 
            // teamTextBox
            // 
            this.teamTextBox.Location = new System.Drawing.Point(127, 130);
            this.teamTextBox.Name = "teamTextBox";
            this.teamTextBox.Size = new System.Drawing.Size(100, 20);
            this.teamTextBox.TabIndex = 12;
            this.teamTextBox.Text = "0";
            // 
            // bringToHomeCheckBox
            // 
            this.bringToHomeCheckBox.AutoSize = true;
            this.bringToHomeCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bringToHomeCheckBox.Checked = true;
            this.bringToHomeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bringToHomeCheckBox.Location = new System.Drawing.Point(134, 156);
            this.bringToHomeCheckBox.Name = "bringToHomeCheckBox";
            this.bringToHomeCheckBox.Size = new System.Drawing.Size(93, 17);
            this.bringToHomeCheckBox.TabIndex = 13;
            this.bringToHomeCheckBox.Text = "Bring to Home";
            this.bringToHomeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bringToHomeCheckBox.UseVisualStyleBackColor = true;
            // 
            // mobileTypeNameTextBox
            // 
            this.mobileTypeNameTextBox.Location = new System.Drawing.Point(127, 214);
            this.mobileTypeNameTextBox.Name = "mobileTypeNameTextBox";
            this.mobileTypeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobileTypeNameTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name:";
            // 
            // spawnMobilesListBox
            // 
            this.spawnMobilesListBox.FormattingEnabled = true;
            this.spawnMobilesListBox.Location = new System.Drawing.Point(15, 269);
            this.spawnMobilesListBox.Name = "spawnMobilesListBox";
            this.spawnMobilesListBox.Size = new System.Drawing.Size(212, 173);
            this.spawnMobilesListBox.TabIndex = 16;
            // 
            // addMobileTypeButton
            // 
            this.addMobileTypeButton.Location = new System.Drawing.Point(152, 240);
            this.addMobileTypeButton.Name = "addMobileTypeButton";
            this.addMobileTypeButton.Size = new System.Drawing.Size(75, 23);
            this.addMobileTypeButton.TabIndex = 17;
            this.addMobileTypeButton.Text = "Add";
            this.addMobileTypeButton.UseVisualStyleBackColor = true;
            this.addMobileTypeButton.Click += new System.EventHandler(this.addMobileTypeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Add a Mobile by type:";
            // 
            // spawnNameTextBox
            // 
            this.spawnNameTextBox.Location = new System.Drawing.Point(127, 16);
            this.spawnNameTextBox.Name = "spawnNameTextBox";
            this.spawnNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.spawnNameTextBox.TabIndex = 15;
            this.spawnNameTextBox.Text = "New_Spawn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uniqueSpawnCheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addMobileTypeButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.spawnMobilesListBox);
            this.groupBox1.Controls.Add(this.mobileTypeNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.spawnNameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.npcCountTextBox);
            this.groupBox1.Controls.Add(this.bringToHomeCheckBox);
            this.groupBox1.Controls.Add(this.homeRangeTextBox);
            this.groupBox1.Controls.Add(this.teamTextBox);
            this.groupBox1.Controls.Add(this.minTimeTextBox);
            this.groupBox1.Controls.Add(this.maxTimeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(248, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 461);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spawn Entry";
            // 
            // uniqueSpawnCheckBox
            // 
            this.uniqueSpawnCheckBox.AutoSize = true;
            this.uniqueSpawnCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uniqueSpawnCheckBox.Location = new System.Drawing.Point(134, 179);
            this.uniqueSpawnCheckBox.Name = "uniqueSpawnCheckBox";
            this.uniqueSpawnCheckBox.Size = new System.Drawing.Size(94, 17);
            this.uniqueSpawnCheckBox.TabIndex = 19;
            this.uniqueSpawnCheckBox.Text = "Unique spawn";
            this.uniqueSpawnCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uniqueSpawnCheckBox.UseVisualStyleBackColor = true;
            // 
            // allSpawnsListBox
            // 
            this.allSpawnsListBox.FormattingEnabled = true;
            this.allSpawnsListBox.Location = new System.Drawing.Point(492, 12);
            this.allSpawnsListBox.Name = "allSpawnsListBox";
            this.allSpawnsListBox.Size = new System.Drawing.Size(163, 446);
            this.allSpawnsListBox.TabIndex = 20;
            this.allSpawnsListBox.SelectedIndexChanged += new System.EventHandler(this.allSpawnsListBox_SelectedIndexChanged);
            this.allSpawnsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allSpawnsListBox_MouseDoubleClick);
            // 
            // loadSpawnButton
            // 
            this.loadSpawnButton.Location = new System.Drawing.Point(12, 467);
            this.loadSpawnButton.Name = "loadSpawnButton";
            this.loadSpawnButton.Size = new System.Drawing.Size(642, 23);
            this.loadSpawnButton.TabIndex = 21;
            this.loadSpawnButton.Text = "Load Spawn File";
            this.loadSpawnButton.UseVisualStyleBackColor = true;
            this.loadSpawnButton.Click += new System.EventHandler(this.loadSpawnButton_Click);
            // 
            // saveSpawnButton
            // 
            this.saveSpawnButton.Location = new System.Drawing.Point(12, 491);
            this.saveSpawnButton.Name = "saveSpawnButton";
            this.saveSpawnButton.Size = new System.Drawing.Size(642, 23);
            this.saveSpawnButton.TabIndex = 22;
            this.saveSpawnButton.Text = "Save Spawn File";
            this.saveSpawnButton.UseVisualStyleBackColor = true;
            this.saveSpawnButton.Click += new System.EventHandler(this.saveSpawnButton_Click);
            // 
            // deleteSpawnButton
            // 
            this.deleteSpawnButton.Location = new System.Drawing.Point(662, 12);
            this.deleteSpawnButton.Name = "deleteSpawnButton";
            this.deleteSpawnButton.Size = new System.Drawing.Size(89, 23);
            this.deleteSpawnButton.TabIndex = 23;
            this.deleteSpawnButton.Text = "Delete Spawn";
            this.deleteSpawnButton.UseVisualStyleBackColor = true;
            this.deleteSpawnButton.Click += new System.EventHandler(this.deleteSpawnButton_Click);
            // 
            // SpawnEntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 526);
            this.Controls.Add(this.deleteSpawnButton);
            this.Controls.Add(this.saveSpawnButton);
            this.Controls.Add(this.loadSpawnButton);
            this.Controls.Add(this.allSpawnsListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mobilesTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpawnEntryWindow";
            this.Text = "Spawn Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mobilesTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox npcCountTextBox;
        private System.Windows.Forms.TextBox homeRangeTextBox;
        private System.Windows.Forms.TextBox minTimeTextBox;
        private System.Windows.Forms.TextBox maxTimeTextBox;
        private System.Windows.Forms.TextBox teamTextBox;
        private System.Windows.Forms.CheckBox bringToHomeCheckBox;
        private System.Windows.Forms.TextBox mobileTypeNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox spawnMobilesListBox;
        private System.Windows.Forms.Button addMobileTypeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox spawnNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox allSpawnsListBox;
        private System.Windows.Forms.Button loadSpawnButton;
        private System.Windows.Forms.CheckBox uniqueSpawnCheckBox;
        private System.Windows.Forms.Button saveSpawnButton;
        private System.Windows.Forms.Button deleteSpawnButton;
    }
}