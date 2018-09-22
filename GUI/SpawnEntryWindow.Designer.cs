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
            this.SuspendLayout();
            // 
            // mobilesTreeView
            // 
            this.mobilesTreeView.Location = new System.Drawing.Point(12, 12);
            this.mobilesTreeView.Name = "mobilesTreeView";
            this.mobilesTreeView.Size = new System.Drawing.Size(230, 410);
            this.mobilesTreeView.TabIndex = 0;
            // 
            // SpawnEntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 434);
            this.Controls.Add(this.mobilesTreeView);
            this.Name = "SpawnEntryWindow";
            this.Text = "Spawn Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mobilesTreeView;
    }
}