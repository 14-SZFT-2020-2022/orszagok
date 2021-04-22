using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis.Feladatok
{
    class Feladat
    {
        public List<Orszag> FeladatMegoldas(MySqlConnection conn)
        {
            List<Orszag> lista = new List<Orszag>();
            string sql = "SELECT * FROM `orszagok`;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            while (mdr.Read())
            {
                Orszag orszag = new Orszag(
                    mdr.GetString(0), 
                    mdr.GetString(1), 
                    mdr.GetString(2), 
                    mdr.GetString(3), 
                    mdr.GetString(4), 
                    mdr.GetString(5), 
                    mdr.GetString(6), 
                    mdr.GetString(7), 
                    mdr.GetString(8),
                    mdr.GetString(9),
                    mdr.GetString(10),
                    mdr.GetString(11),
                    mdr.GetString(12),
                    mdr.GetString(13),
                    mdr.GetString(14),
                    mdr.GetString(15)
                    );
                lista.Add(orszag);
            }

            return lista;
        }
    }
}
