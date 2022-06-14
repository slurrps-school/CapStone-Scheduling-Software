using MySql.Data.MySqlClient;
using SchedulingSoftware.Data_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware.Class
{
    public class connection
    {
        //DONE
        //Conection String for the program
        #region ConnectionString
        //Creates the connection string for the SQL Methods
        protected static string BuildPrimaryConnection()
        {
            string server = "162.241.244.52";
            string port = "3306";
            string database = "kenneue4_client_schedule";
            string userID = "kenneue4_sqlUser ";
            string password = "Black77690!?@";
            string connectionString = "server=" + server + ";" + "port=" + port + ";" + "uid=" + userID + ";" +
                "database=" + database + ";" + "pwd=" + password + ";" + "Allow Zero Datetime=true";

            //string server = "162.241.244.52";
            //string port = "3306";
            //string database = "kenneue4_client_schedule";
            //string userID = "kenneue4_sqlUser";
            //string password = "Morgan7089!?@";
            //string connectionString = "server=" + server + ";" + "port=" + port + ";" + "uid=" + userID + ";" +
            //    "database=" + database + ";" + "pwd=" + password + ";" + "Allow Zero Datetime=true";

            return connectionString;
        }

        #endregion

        //DONE
        //Used to get data tables via SQL statements
        #region SQL Methods
        //Get data table from a SQL query or SQL Function
        public static DataTable GetDataTableSQL(string strSQL)
        {
            //Create the resultsTable
            DataTable resultsTable = new DataTable();

            // Create objects for sql transaction
            MySqlDataAdapter da = new MySqlDataAdapter(); //Adapter to fill the datatable
            var conn = new MySqlConnection(BuildPrimaryConnection()); //New Connection

            try
            {
                // Open connection
                conn.Open();

                // Create our Sql Command & give it properties
                MySqlCommand command = new MySqlCommand();
                command.CommandType = CommandType.Text; //Text Command
                command.CommandText = strSQL; //Set text to incomming string

                // Send command to open connection
                command.Connection = conn;
                da.SelectCommand = command;
                // Fill results table and dispose of data adapter
                da.Fill(resultsTable);
                da.Dispose();

                // Close connection
                conn.Close();
            }
            catch (Exception ex)
            {
                // If the function fails, dispose of connection
                conn.Close();
                conn.Dispose();
                //Test logging errors to check what is failing
                //LogErrorActivity("Username: '" + users.userName + "'. UserID: " + users.userId + "Error Failed to run SQL statement " + ex + " " + DateTime.Now);
            }
            // Return results table
            return resultsTable;
        }
        #endregion

    }
}
