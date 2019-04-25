using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace NetCore.Models
{
    public class MusicStoreContext
    {
        public static string ConnectionString { get; set; }

     

        public MusicStoreContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }



    }
}
