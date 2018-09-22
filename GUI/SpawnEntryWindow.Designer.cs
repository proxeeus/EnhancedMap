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
            this.SuspendLayout();
            // 
            // mobilesTreeView
            // 
            this.mobilesTreeView.HideSelection = false;
            this.mobilesTreeView.Location = new System.Drawing.Point(12, 12);
            this.mobilesTreeView.Name = "mobilesTreeView";
            this.mobilesTreeView.Size = new System.Drawing.Size(230, 410);
            this.mobilesTreeView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NPC Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Min time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Team:";
            // 
            // npcCountTextBox
            // 
            this.npcCountTextBox.Location = new System.Drawing.Point(342, 26);
            this.npcCountTextBox.Name = "npcCountTextBox";
            this.npcCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.npcCountTextBox.TabIndex = 7;
            this.npcCountTextBox.Text = "1";
            // 
            // homeRangeTextBox
            // 
            this.homeRangeTextBox.Location = new System.Drawing.Point(342, 49);
            this.homeRangeTextBox.Name = "homeRangeTextBox";
            this.homeRangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeRangeTextBox.TabIndex = 8;
            this.homeRangeTextBox.Text = "5";
            // 
            // minTimeTextBox
            // 
            this.minTimeTextBox.Location = new System.Drawing.Point(342, 72);
            this.minTimeTextBox.Name = "minTimeTextBox";
            this.minTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTimeTextBox.TabIndex = 10;
            this.minTimeTextBox.Text = "2.5";
            // 
            // maxTimeTextBox
            // 
            this.maxTimeTextBox.Location = new System.Drawing.Point(342, 94);
            this.maxTimeTextBox.Name = "maxTimeTextBox";
            this.maxTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTimeTextBox.TabIndex = 11;
            this.maxTimeTextBox.Text = "10.0";
            // 
            // teamTextBox
            // 
            this.teamTextBox.Location = new System.Drawing.Point(342, 117);
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
            this.totalRespawnCheckBox.Location = new System.Drawing.Point(349, 143);
            this.totalRespawnCheckBox.Name = "totalRespawnCheckBox";
            this.totalRespawnCheckBox.Size = new System.Drawing.Size(93, 17);
            this.totalRespawnCheckBox.TabIndex = 13;
            this.totalRespawnCheckBox.Text = "Total respawn";
            this.totalRespawnCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalRespawnCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpawnEntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 434);
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
    }
}