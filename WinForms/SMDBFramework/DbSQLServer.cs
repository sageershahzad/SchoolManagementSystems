using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SMDBFramework
{
   public class DbSQLServer
    {
        //Execute Reader, Execute Scalar, Execute No Query
        private string _connstring;

        public DbSQLServer(string connstring)
        {
            _connstring = connstring;
        }

        public DataTable GetDataList(string storedProcedureName)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                //SqlCommand object allows you to query and send commands to a database.
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        public DataTable GetDataList(string storedProcedureName, DbParameter parameter)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                //SqlCommand object allows you to query and send commands to a database.
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }


        public DataTable GetDataList(string storedProcedureName, DbParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                //SqlCommand object allows you to query and send commands to a database.
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    foreach(var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }


        public void SaveOrUpdateRecord(string storedProcedureName, object obj)
        {
            

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                //SqlCommand object allows you to query and send commands to a database.
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    //Parameters
                    Type type = obj.GetType();
                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] properties = type.GetProperties(flags);

        foreach (var property in properties)
        {
            cmd.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj, null));
        }

                    cmd.ExecuteNonQuery();
                }
            }

            
        }


        //Overloading
        public object GetScalarValue(string storedProcedureName)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                //SqlCommand object allows you to query and send commands to a database.
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    value = cmd.ExecuteScalar();
                }
            }

            return value;
        }

        public object GetScalarValue(string storedProcedureName, DbParameter parameter)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

                    value = cmd.ExecuteScalar();
                }
            }

            return value;
        }


        public object GetScalarValue(string storedProcedureName, DbParameter[] parameters)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connstring))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    foreach(var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    

                    value = cmd.ExecuteScalar();
                }
            }

            return value;
        }

    }
}
