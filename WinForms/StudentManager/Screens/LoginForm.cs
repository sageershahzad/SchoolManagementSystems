using SMDBFramework;
using SMDBFramework.Windows;
using StudentManager.Models.Users;
using StudentManager.Screens.Templates;
using StudentManager.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManager.Screens
{
    public partial class LoginForm : TemplateForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());

                bool isLoginDetailsCorrect = Convert.ToBoolean(dbSQLServer.GetScalarValue("usp_UsersCheckLoginDetails", GetParameters()));

                if (isLoginDetailsCorrect)
                {
                    GetLoggedInUserSettings();
                    this.Hide();

                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.Show();
                }

                else
                {
                    JIMessageBox.ShowErrorMessage("User Name/Password is incorrect");
                    //MessageBox.Show("User Name/Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void GetLoggedInUserSettings()
        {
            LoggedInUser.UserName = textBoxForUserName.Text.Trim();
        }

        private DbParameter[] GetParameters()
        {
            List<DbParameter> parameters = new List<DbParameter>();
            DbParameter dbparam1 = new DbParameter();
            dbparam1.Parameter = ("@UserName");
            dbparam1.Value = textBoxForUserName.Text;
            parameters.Add(dbparam1);

            DbParameter dbparam2 = new DbParameter();
            dbparam2.Parameter = ("@Password");
            dbparam2.Value = textBoxForPassword.Text;
            parameters.Add(dbparam2);


            return parameters.ToArray();
        }

        private bool IsFormValid()
        {
            if (textBoxForUserName.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("User Name is required");
                //MessageBox.Show("User Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxForUserName.Clear();
                textBoxForUserName.Focus();
                return false;
            }

            if (textBoxForPassword.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Password is required");
                //MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxForPassword.Clear();
                textBoxForPassword.Focus();
                return false;
            }
            return true;
        }
    }
}
