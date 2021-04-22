using System;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis.Feladatok
{
    class Feladat2
    {
        public MySqlDataReader FeladatMegoldas(MySqlConnection conn)
        {
            Console.WriteLine("2. Feladat: Mely országok népsűrűsége nagyobb 500 fő/km2-nél?");

            string sql = "SELECT `orszag` AS `Orszag`, `nepesseg` * 1000 / `terulet` ";
            sql += "AS `Nepsuruség (fo/km^2)` FROM `orszagok`  WHERE `nepesseg` * 1000 / `terulet` > 500;"; 

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            return mdr;
        }
    }
}
