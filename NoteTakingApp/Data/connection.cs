using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NoteTakingApp.Data
{
    internal class connection
    {

        public static MySqlConnection serverData = new MySqlConnection();

        static string server = "127.0.0.1;";
        static string database = "my_database.users;";
        static string Uid = "root;";
        static string password = ";";

        public static MySqlConnection datasource()
        {
            serverData = new MySqlConnection($"server ={server} database={database} Uid={Uid} password={password}");
            return serverData;
        }

        public void connectionOpen()
        {
            datasource();
            serverData.Open();
        }

        public void connectionClose()
        {
            datasource();
            serverData.Close();
        }
    }
}
