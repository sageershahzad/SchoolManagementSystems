namespace StudentManager.Screens.Employees
{
    partial class ManageEmployeesForm
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
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.AllowUserToAddRows = false;
            this.EmployeesDataGridView.AllowUserToDeleteRows = false;
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGridView.Location = new System.Drawing.Point(13, 44);
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.ReadOnly = true;
            this.EmployeesDataGridView.RowTemplate.Height = 24;
            this.EmployeesDataGridView.Size = new System.Drawing.Size(1141, 427);
            this.EmployeesDataGridView.TabIndex = 1;
            this.EmployeesDataGridView.DoubleClick += new System.EventHandler(this.EmployeesDataGridView_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeEmployeeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewEmployeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeEmployeeToolStripMenuItem
            // 
            this.closeEmployeeToolStripMenuItem.Name = "closeEmployeeToolStripMenuItem";
            this.closeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.closeEmployeeToolStripMenuItem.Text = "&Close";
            this.closeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.closeEmployeeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 486);
            this.Controls.Add(this.EmployeesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageEmployeesForm";
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.ManageEmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.DataGridView EmployeesDataGridView;
    }
}