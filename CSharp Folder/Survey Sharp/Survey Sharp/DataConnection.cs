using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_Sharp
{
    class DataConnection
    {
        private string conServer;
        private MySqlConnection connect;


        private void Database_Connection()
        {
            try
            {
                conServer = "Server=localhost;Database=csharp;Uid=root;Pwd='';";
                connect = new MySqlConnection(conServer);
                connect.Open();
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }

        public bool Connection_Control()
        {
            try
            {
                Database_Connection();
                return true;
            }

            catch (Exception)
            {
                return false;

            }

        }

        public bool validate_login(string user, string pass)
        {
            Connection_Control();
            MySqlCommand MySQLCmd = new MySqlCommand();
            MySQLCmd.CommandText = "Select * from login where name=@user and pass=@pass";
            MySQLCmd.Parameters.AddWithValue("@user", user);
            MySQLCmd.Parameters.AddWithValue("@pass", pass);
            MySQLCmd.Connection = connect;
            MySqlDataReader login = MySQLCmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
    }
}

