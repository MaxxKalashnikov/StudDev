﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALVERSIONIHOPE
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=8889; username=root; password=root; database=mytry");

        public void openconnection()
            {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            }

        public void closeconnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

        }

        public MySqlConnection getconnection()
        {
            return connection;
        }
    }
}
