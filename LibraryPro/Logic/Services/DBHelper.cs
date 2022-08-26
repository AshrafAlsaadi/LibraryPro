using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryPro.Logic.Services
{
   static class DBHelper
    {
        public static SqlCommand command;
        //get connection string from sqlserver
        private static SqlConnection getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource =Properties.Settings.Default.ServerName;
            builder.InitialCatalog = Properties.Settings.Default.DBName;
            builder.IntegratedSecurity = true;
            return new SqlConnection(builder.ConnectionString);
        }
        //make inset ,update,Delete,DeleteAll in database in all program
        public static bool executeData(string spName,Action method)
        {
            using (SqlConnection connection= getConnectionString())
            {
                try
                {
                    
                    command = new SqlCommand(spName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    //to execute method contain Parameters
                    method.Invoke();

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
           
        }
    }
}
