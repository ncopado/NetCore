using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace NetCore.Models
{
    public class data
    {

        

        public static List<Album> GetAllAlbums()
        {
            List<Album> list = new List<Album>();

            using (MySqlConnection conn =  MusicStoreContext.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("getTest", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Album()
                        {
                            Id = Convert.ToInt32(reader["IdTest"]),
                            Name = reader["Name"].ToString(),

                        });
                    }
                }
            }
            return list;
        }
    }
}
