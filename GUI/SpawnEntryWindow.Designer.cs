namespace EnhancedMap.GUI
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
            this.totalRespawnCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spawnMobilesListBox = new System.Windows.Forms.ListBox();
            this.addMobileTypeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.spawnNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mobilesTreeView
            // 
            this.mobilesTreeView.HideSelection = false;
            this.mobilesTreeView.Location = new System.Drawing.Point(12, 12);
            this.mobilesTreeView.Name = "mobilesTreeView";
            this.mobilesTreeView.Size = new System.Drawing.Size(230, 410);
            this.mobilesTreeView.TabIndex = 0;
            this.mobilesTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mobilesTreeView_NodeMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NPC Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Min time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Team:";
            // 
            // npcCountTextBox
            // 
            this.npcCountTextBox.Location = new System.Drawing.Point(337, 42);
            this.npcCountTextBox.Name = "npcCountTextBox";
            this.npcCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.npcCountTextBox.TabIndex = 7;
            this.npcCountTextBox.Text = "1";
            // 
            // homeRangeTextBox
            // 
            this.homeRangeTextBox.Location = new System.Drawing.Point(337, 65);
            this.homeRangeTextBox.Name = "homeRangeTextBox";
            this.homeRangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeRangeTextBox.TabIndex = 8;
            this.homeRangeTextBox.Text = "5";
            // 
            // minTimeTextBox
            // 
            this.minTimeTextBox.Location = new System.Drawing.Point(337, 88);
            this.minTimeTextBox.Name = "minTimeTextBox";
            this.minTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTimeTextBox.TabIndex = 10;
            this.minTimeTextBox.Text = "2.5";
            // 
            // maxTimeTextBox
            // 
            this.maxTimeTextBox.Location = new System.Drawing.Point(337, 110);
            this.maxTimeTextBox.Name = "maxTimeTextBox";
            this.maxTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTimeTextBox.TabIndex = 11;
            this.maxTimeTextBox.Text = "10.0";
            // 
            // teamTextBox
            // 
            this.teamTextBox.Location = new System.Drawing.Point(337, 133);
            this.teamTextBox.Name = "teamTextBox";
            this.teamTextBox.Size = new System.Drawing.Size(100, 20);
            this.teamTextBox.TabIndex = 12;
            this.teamTextBox.Text = "0";
            // 
            // totalRespawnCheckBox
            // 
            this.totalRespawnCheckBox.AutoSize = true;
            this.totalRespawnCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalRespawnCheckBox.Checked = true;
            this.totalRespawnCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.totalRespawnCheckBox.Location = new System.Drawing.Point(344, 159);
            this.totalRespawnCheckBox.Name = "totalRespawnCheckBox";
            this.totalRespawnCheckBox.Size = new System.Drawing.Size(93, 17);
            this.totalRespawnCheckBox.TabIndex = 13;
            this.totalRespawnCheckBox.Text = "Total respawn";
            this.totalRespawnCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalRespawnCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(378, 222);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name:";
            // 
            // spawnMobilesListBox
            // 
            this.spawnMobilesListBox.FormattingEnabled = true;
            this.spawnMobilesListBox.Location = new System.Drawing.Point(265, 248);
            this.spawnMobilesListBox.Name = "spawnMobilesListBox";
            this.spawnMobilesListBox.Size = new System.Drawing.Size(294, 173);
            this.spawnMobilesListBox.TabIndex = 16;
            // 
            // addMobileTypeButton
            // 
            this.addMobileTypeButton.Location = new System.Drawing.Point(484, 220);
            this.addMobileTypeButton.Name = "addMobileTypeButton";
            this.addMobileTypeButton.Size = new System.Drawing.Size(75, 23);
            this.addMobileTypeButton.TabIndex = 17;
            this.addMobileTypeButton.Text = "Add";
            this.addMobileTypeButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Add a Mobile by type:";
            // 
            // spawnNameTextBox
            // 
            this.spawnNameTextBox.Location = new System.Drawing.Point(337, 19);
            this.spawnNameTextBox.Name = "spawnNameTextBox";
            this.spawnNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.spawnNameTextBox.TabIndex = 15;
            this.spawnNameTextBox.Text = "New_Spawn";
            // 
            // SpawnEntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 434);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addMobileTypeButton);
            this.Controls.Add(this.spawnMobilesListBox);
            this.Controls.Add(this.spawnNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalRespawnCheckBox);
            this.Controls.Add(this.teamTextBox);
            this.Controls.Add(this.maxTimeTextBox);
            this.Controls.Add(this.minTimeTextBox);
            this.Controls.Add(this.homeRangeTextBox);
            this.Controls.Add(this.npcCountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mobilesTreeView);
            this.Name = "SpawnEntryWindow";
            this.Text = "Spawn Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox totalRespawnCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox spawnMobilesListBox;
        private System.Windows.Forms.Button addMobileTypeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox spawnNameTextBox;
    }
}