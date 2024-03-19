using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSZI2v2
{
    public class Database
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=rszi");


        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            connect.Open();
        }

        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            connect.Close();
        }

        public MySqlConnection getConnect()
        {
            return connect;
        }
    }
}