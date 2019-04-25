using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace NetCore.Models
{
    public class DBContext
    {
        public static string ConnectionString { get; set; }

        public DBContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }





    }
}
