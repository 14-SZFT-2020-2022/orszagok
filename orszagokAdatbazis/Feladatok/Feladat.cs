using System;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis.Feladatok
{
    class Feladat
    {
        public MySqlDataReader FeladatMegoldas(MySqlConnection conn)
        {
            string sql = "SELECT * FROM `orszagok`;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            return mdr;
        }
    }
}
