using StudentManager.Screens.Templates;
using StudentManager.Utilities.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Branches
{
    public partial class ManageBranchesForm : TemplateForm
    {
        public ManageBranchesForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBranchInfoForm(0, false);
        }

        private void ShowBranchInfoForm(int branchId, bool isUpdate)
        {
            BranchInfoForm branchInfoFormObject = new BranchInfoForm();
            branchInfoFormObject.BranchId = branchId;
            branchInfoFormObject.IsUpdate = isUpdate;
            branchInfoFormObject.ShowDialog();
            LoadDataIntoDataGridView();
        }

        private void ManageBranchesForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(ManageBranchesDataGridView, "usp_BranchesGetAllBranches"); 
             
        }

        private void ManageBranchesDataGridView_DoubleClick(object sender, EventArgs e)
        {
           int rowIndex = ManageBranchesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            int branchId = Convert.ToInt32(ManageBranchesDataGridView.Rows[rowIndex].Cells["BranchId"].Value);

            ShowBranchInfoForm(branchId, true);
        }
    }
}
