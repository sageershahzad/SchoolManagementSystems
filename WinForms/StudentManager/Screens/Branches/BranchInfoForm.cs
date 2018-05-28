using SMDBFramework;
using SMDBFramework.Windows;
using StudentManager.Models.Branches;
using StudentManager.Models.Users;
using StudentManager.Screens.Templates;
using StudentManager.Utilities;
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
    public partial class BranchInfoForm : TemplateForm
    {
        public BranchInfoForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int BranchId { get; set; }

        private void BranchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelSchoolLabel.Text = BranchNameTextBox.Text;
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            GetPhoto();

        }

        private void GetPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Logo";
            openFileDialog.Filter = "Logo File (*.png; *.jpg; *.bmp; *.gif) | *.png; *.jpg; *.bmp; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LogoPictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void BranchInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            LoadDataAndBindToControlIfUpdate();
        }

        private void LoadDataIntoComboBoxes()
        {
    ListData.LoadDataIntoComboBox(CityComboBox1, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.City });

    ListData.LoadDataIntoComboBox(DistrictComboBox2, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.District });

        }

        private void LoadDataAndBindToControlIfUpdate()
        {
            if (this.IsUpdate)
            {
                DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());
                //DbParameter dbPara = new DbParameter();
                //dbPara.Parameter = "@BranchId";
                //dbPara.Value = this.BranchId;
           DataTable dtBranchTable = dbSQLServer.GetDataList("usp_BranchesGetBrancheDetailByBranchId", new DbParameter { Parameter = "@BranchId", Value = this.BranchId});
                DataRow row = dtBranchTable.Rows[0];

                BranchNameTextBox.Text = row["BranchName"].ToString();
                EmailTextBox.Text = row["Email"].ToString();
                MobileTextBox.Text = row["Mobile"].ToString();
                WebAddressTextBox.Text = row["Website"].ToString();
                LogoPictureBox.Image = (row["branchImage"] is DBNull)? null : ImageManipulations.PutPhoto((byte[])row["branchImage"]);
                AddressLineTextBox.Text = row["AddressLine"].ToString();
                CityComboBox1.SelectedValue = row["CityId"];
                DistrictComboBox2.SelectedValue = row["DistrictId"];
                PostCodeTextBox.Text = row["PostCode"].ToString();
            }
        }

        private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(IsFormValidated())
            {
                if (this.IsUpdate)
                {
                    SaveOrUpdateRecord("usp_BranchesUpdateBranchesDetails");
                    JIMessageBox.ShowSuccessMessage("Record is updated successfully");
                    
                }

               
                else
                {
                    SaveOrUpdateRecord("usp_BranchesAddNewBranches");

                    JIMessageBox.ShowSuccessMessage("Record is Added successfully");
                    
                }

                this.Close();

            }


        }

        private void SaveOrUpdateRecord(string storedProcedureName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord(storedProcedureName, GetObject());
        }

        private Branch GetObject()
        {
            Branch branch = new Branch();
            branch.BranchId = (this.IsUpdate) ? this.BranchId : 0;
            branch.BranchName = BranchNameTextBox.Text;
            branch.Email = EmailTextBox.Text;
            branch.Mobile = MobileTextBox.Text;
            branch.Website = WebAddressTextBox.Text;
            branch.AddressLine = AddressLineTextBox.Text;
            branch.CityId = Convert.ToInt32(CityComboBox1.SelectedValue);
            branch.DistrictId = Convert.ToInt32(DistrictComboBox2.SelectedValue);
            branch.PostCode = PostCodeTextBox.Text;
            branch.BranchImage = (LogoPictureBox.Image == null) ? null : ImageManipulations.GetPhoto(LogoPictureBox);
            branch.CreatedBy = LoggedInUser.UserName;

            return branch;
        }

       

        private bool IsFormValidated()
        {
            if (BranchNameTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Branch Name is required.");

                //MessageBox.Show("Branch Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BranchNameTextBox.Focus();
                return false;
            }

            if (EmailTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Email is required");
                //MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //EmailTextBox.Focus();
                return false;
            }

            if (MobileTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Mobile is required");
                //MessageBox.Show("Mobile is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MobileTextBox.Focus();
                return false;
            }
            return true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GetPhoto();
        }

        private void CancelPictureBox_Click(object sender, EventArgs e)
        {
            LogoPictureBox.Image = null;
        }
    }
}
