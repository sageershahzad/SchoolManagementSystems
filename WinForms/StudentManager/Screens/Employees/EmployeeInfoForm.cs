using SMDBFramework;
using SMDBFramework.Windows;
using StudentManager.Models.Employees;
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

namespace StudentManager.Screens.Employees
{
    public partial class EmployeeInfoForm : TemplateForm
    {
        public EmployeeInfoForm()
        {
            InitializeComponent();
        }

        public int EmployeeId { get; set; }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

     //Here
  private void EmployeeInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();


            if (this.IsUpdate)
            {
                LoadDataAndBindIntoControls();
                EnableButtons();
            }


            else
            {
                GenerateEmployeeId();
            }
        }

        private void LoadDataAndBindIntoControls()
        {
            DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());
            DataTable dataTabe = dbSQLServer.GetDataList("usp_EmployeesGetEmployeesDetailsById", new DbParameter
            {
                Parameter = "@EmployeeId",
                Value = this.EmployeeId
            });

            DataRow dtRow = dataTabe.Rows[0];

            EmployeeIDTextBox.Text = dtRow["EmployeeId"].ToString();
            FullNameTextBox.Text = dtRow["FullName"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dtRow["DateOfBirth"]);
            NICTextBox.Text = dtRow["NICNumber"].ToString();
            EmailTextBox.Text = dtRow["EmailAddress"].ToString();
            TelephoneTextBox.Text = dtRow["Telephone"].ToString();
            MobileETextBox.Text = dtRow["Mobile"].ToString();
            dateTimePicker2.Value = Convert.ToDateTime(dtRow["EmploymentDate"]);
            AddressLineTextBox.Text = dtRow["AddressLine"].ToString();
            PostCodeBox.Text = dtRow["PostCode"].ToString();
            CurrentSalaryTextBox.Text = dtRow["CurrentSalary"].ToString();
            StartingSalaryTextBox.Text = dtRow["StartingSalary"].ToString();
            CommentsTextBox.Text = dtRow["Comments"].ToString();
            pictureBox1.Image = (dtRow["Photo"] is DBNull) ? null : ImageManipulations.PutPhoto((byte[])dtRow["Photo"]);
            CityComboBox.SelectedValue = dtRow["CityId"];
            DistrictComboBox.SelectedValue = dtRow["DistrictId"];
            GenderComboBox.SelectedValue = dtRow["GenderId"];
            BranchComboBox.SelectedValue = dtRow["BranchId"];
            JobTitleComboBox.SelectedValue = dtRow["JobTitleId"];
            HasLeftComboBox.Text = (Convert.ToBoolean(dtRow["HasLeft"]) == true) ? "Yes" : "No";
            ReasonLeftComboBox.SelectedValue = dtRow["ReasonLeftId"];
            DateLeftDateTimePicker.Value = Convert.ToDateTime(dtRow["DateLeft"]);
            CommentsTextBox.Text = dtRow["Comments"].ToString();
           

        }

        private void LoadDataIntoComboBoxes()
        {
    ListData.LoadDataIntoComboBox(BranchComboBox, "usp_BranchesGetAllBranchesName");


    ListData.LoadDataIntoComboBox(GenderComboBox, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.Gender });

    ListData.LoadDataIntoComboBox(CityComboBox, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.City});

    ListData.LoadDataIntoComboBox(DistrictComboBox, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.District });

    ListData.LoadDataIntoComboBox(JobTitleComboBox, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.EmployeeJobTitle });

    ListData.LoadDataIntoComboBox(HasLeftComboBox, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.YesNo });

    ListData.LoadDataIntoComboBox(ReasonLeftComboBox, new DbParameter { Parameter = "@ListTypeId", Value = ListTypes.EmployeeReasonLeft });

            


        }

        private void GenerateEmployeeId()
        {
            DbSQLServer dBSQLSerevr = new DbSQLServer(AppSetting.ConnectionString());
            EmployeeIDTextBox.Text = dBSQLSerevr.GetScalarValue("usp_EmployeesGenerateNewEmployeeId").ToString();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            GetPhoto();
        }

        private void GetPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Photo";
            openFileDialog.Filter = "Photo File (*.png; *.jpg; *.bmp; *.gif) | *.png; *.jpg; *.bmp; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GetPhoto();
        }

        private void CancelPictureBox_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

       
        private void SaveOrUpdateRecord(string storedProcedureName)
        {
            DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());
            dbSQLServer.SaveOrUpdateRecord(storedProcedureName, GetObject());
        }

        private Employee GetObject()
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(EmployeeIDTextBox.Text);
            emp.FullName = FullNameTextBox.Text;
            emp.DateOfBirth = dateTimePicker1.Value.Date;
            emp.NICNumber = NICTextBox.Text.Trim();
            emp.EmailAddress = EmailTextBox.Text.Trim();
            emp.Mobile = MobileETextBox.Text.Trim();
            emp.Telephone = TelephoneTextBox.Text.Trim();
            emp.GenderId = (GenderComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(GenderComboBox.SelectedValue);

            emp.BranchId = (BranchComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(BranchComboBox.SelectedValue);

            emp.EmploymentDate = dateTimePicker2.Value.Date;

            emp.Photo = (pictureBox1.Image == null) ? null : ImageManipulations.GetPhoto(pictureBox1);

            emp.AddressLine = AddressLineTextBox.Text.Trim();

            emp.CityId = (CityComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(CityComboBox.SelectedValue);

            emp.DistrictId = (DistrictComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(DistrictComboBox.SelectedValue);

            emp.PostCode = PostCodeBox.Text.Trim();

            emp.JobTitleId = (JobTitleComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(JobTitleComboBox.SelectedValue);

            emp.CurrentSalary = Convert.ToDecimal(CurrentSalaryTextBox.Text.Trim());
            emp.StartingSalary = Convert.ToDecimal(StartingSalaryTextBox.Text.Trim());

            emp.HasLeft = (HasLeftComboBox.Text.Trim() == "Yes") ? true : false;
            emp.DateLeft = DateLeftDateTimePicker.Value.Date;

            emp.ReasonLeftId = (ReasonLeftComboBox.SelectedIndex == -1) ? 0 : Convert.ToInt32(ReasonLeftComboBox.SelectedValue);

            emp.Comments = CommentsTextBox.Text.Trim();
            emp.CreatedBy = LoggedInUser.UserName;

            return emp;
        }

        private bool IsFormValid()
        {
            if (FullNameTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Full Name is required.");
                FullNameTextBox.Focus();
                return false;
            }

            if (NICTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("NIC is required");
                NICTextBox.Focus();
                return false;
            }

            if ((MobileETextBox.Text.Trim() == string.Empty) && (TelephoneTextBox.Text.Trim() == string.Empty))
            {
                JIMessageBox.ShowErrorMessage("Number is required");
                return false;
            }

            if (GenderComboBox.SelectedIndex == -1)
            {
                JIMessageBox.ShowErrorMessage("Gender is required");
                GenderComboBox.Focus();
                return false;
            }

            if (AddressLineTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Address is required");
                AddressLineTextBox.Focus();
                return false;
            }

            if (CityComboBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("City is required");
                CityComboBox.Focus();
                return false;
            }

            if (DistrictComboBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("District is required");
                DistrictComboBox.Focus();
                return false;
            }

            if (PostCodeBox.Text.Trim() == string.Empty)
            { 
                JIMessageBox.ShowErrorMessage("Post Code is required");
                PostCodeBox.Focus();
                return false;
            }

            if (JobTitleComboBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Job Title is required");
                JobTitleComboBox.Focus();
                return false;
            }

            if (CurrentSalaryTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Current Salary is required");
                CurrentSalaryTextBox.Focus();
                return false;
            }

            else
            {
                if (Convert.ToDecimal(CurrentSalaryTextBox.Text.Trim()) < 1)
                {
                    JIMessageBox.ShowErrorMessage("Current Salary Cannot be Zero or Less");
                    CurrentSalaryTextBox.Focus();
                    return false;
                }
            }

            if (StartingSalaryTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Starting Salary is required");
                StartingSalaryTextBox.Focus();
                return false;
            }

            else
            {
                if (Convert.ToDecimal(StartingSalaryTextBox.Text.Trim()) < 1)
                {
                    JIMessageBox.ShowErrorMessage("Starting Salary Cannot be Zero or Less");
                    StartingSalaryTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (this.IsUpdate)
                {
                    SaveOrUpdateRecord("usp_EmployeesUpdateEmpDetails");
                    JIMessageBox.ShowSuccessMessage("Record is updated successfully");
                    this.Close();

                }

                else
                {
                    SaveOrUpdateRecord("usp_EmployeesAddNewEmp");
                    JIMessageBox.ShowSuccessMessage("Record is updated successfully");

                    this.IsUpdate = true;
                    EnableButtons();
                    this.Close();
                }


            }
        }

        private void EnableButtons()
        {
            AddBTNEmployee.Enabled = true;
            SendBTNEmployee.Enabled = true;
            PrintBTNEmployee.Enabled = true;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelEmployeeInfoLabel.Text = FullNameTextBox.Text; 
        }
    }
}
