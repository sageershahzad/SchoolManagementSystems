namespace StudentManager.Branches
{
    partial class ManageBranchesForm
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
            this.ManageBranchesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageBranchesDataGridView = new System.Windows.Forms.DataGridView();
            this.ManageBranchesMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBranchesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageBranchesMenuStrip
            // 
            this.ManageBranchesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ManageBranchesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewBranchToolStripMenuItem});
            this.ManageBranchesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ManageBranchesMenuStrip.Name = "ManageBranchesMenuStrip";
            this.ManageBranchesMenuStrip.Size = new System.Drawing.Size(1013, 28);
            this.ManageBranchesMenuStrip.TabIndex = 0;
            this.ManageBranchesMenuStrip.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // addNewBranchToolStripMenuItem
            // 
            this.addNewBranchToolStripMenuItem.Name = "addNewBranchToolStripMenuItem";
            this.addNewBranchToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.addNewBranchToolStripMenuItem.Text = "Add New Branch";
            this.addNewBranchToolStripMenuItem.Click += new System.EventHandler(this.addNewBranchToolStripMenuItem_Click);
            // 
            // ManageBranchesDataGridView
            // 
            this.ManageBranchesDataGridView.AllowUserToAddRows = false;
            this.ManageBranchesDataGridView.AllowUserToDeleteRows = false;
            this.ManageBranchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageBranchesDataGridView.Location = new System.Drawing.Point(12, 45);
            this.ManageBranchesDataGridView.Name = "ManageBranchesDataGridView";
            this.ManageBranchesDataGridView.ReadOnly = true;
            this.ManageBranchesDataGridView.RowTemplate.Height = 24;
            this.ManageBranchesDataGridView.Size = new System.Drawing.Size(989, 479);
            this.ManageBranchesDataGridView.TabIndex = 1;
            this.ManageBranchesDataGridView.DoubleClick += new System.EventHandler(this.ManageBranchesDataGridView_DoubleClick);
            // 
            // ManageBranchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 536);
            this.Controls.Add(this.ManageBranchesDataGridView);
            this.Controls.Add(this.ManageBranchesMenuStrip);
            this.MainMenuStrip = this.ManageBranchesMenuStrip;
            this.Name = "ManageBranchesForm";
            this.Text = "Manage Branches";
            this.Load += new System.EventHandler(this.ManageBranchesForm_Load);
            this.ManageBranchesMenuStrip.ResumeLayout(false);
            this.ManageBranchesMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBranchesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ManageBranchesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewBranchToolStripMenuItem;
        private System.Windows.Forms.DataGridView ManageBranchesDataGridView;
    }
}