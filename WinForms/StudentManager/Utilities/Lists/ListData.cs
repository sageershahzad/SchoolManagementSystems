using SMDBFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Utilities.Lists
{
    public class ListData
    {
        public static void LoadDataIntoDataGridView(DataGridView dataGridView, string storedProcedureName)
        {
            DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());

            dataGridView.DataSource = dbSQLServer.GetDataList(storedProcedureName);

            dataGridView.MultiSelect = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public static void LoadDataIntoComboBox(ComboBox comboBox, DbParameter dbParameter)
        {
            DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());

            comboBox.DataSource = dbSQLServer.GetDataList("usp_GetListTypesDataById", dbParameter);

            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = -1;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        //this
        public static void LoadDataIntoComboBox(ComboBox comboBox, string storedProcedureName)
        {
            DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());

            comboBox.DataSource = dbSQLServer.GetDataList(storedProcedureName);

            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = -1;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public static void LoadDataIntoComboBox(ComboBox comboBox, string storedProcedureName, DbParameter dbParameter)
        {
            DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());

            comboBox.DataSource = dbSQLServer.GetDataList(storedProcedureName, dbParameter);

            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = -1;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public static void LoadDataIntoComboBox(ComboBox comboBox, string storedProcedureName, DbParameter[] dbParameters)
        {
            DbSQLServer dbSQLServer = new DbSQLServer(AppSetting.ConnectionString());

            comboBox.DataSource = dbSQLServer.GetDataList(storedProcedureName, dbParameters);

            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = -1;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

    }
}
