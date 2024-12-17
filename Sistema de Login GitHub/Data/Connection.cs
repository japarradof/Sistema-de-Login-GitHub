using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Login_GitHub.Data
{
    internal static class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();

        public static string server = "127.0.0.1";
        public static string database = "login";
        public static string user = "root";
        public static string password = "18082000";

        public static void openConnection()
        {
            // 
            string connectionString = $"server={server}; database={database}; user={user}; password={password};";

            // 
            connMaster = new MySqlConnection(connectionString);

            // 
            connMaster.Open();

            if (connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexión Establecida");
            }

            else
            {
                MessageBox.Show("Conexión Fallida.");
            }
        }

        public static void closeConnection() 
        { 

        }
    }
}
