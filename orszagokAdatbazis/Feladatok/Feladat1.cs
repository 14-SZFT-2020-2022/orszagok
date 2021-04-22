using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis.Feladatok
{
    class Feladat1
    {
        public MySqlDataReader FeladatMegoldas(MySqlConnection conn)
        {
            Console.WriteLine("1. Feladat: Mi MADAGASZKÁR fővárosa?");

            string sql = "SELECT `fovaros` FROM `orszagok` WHERE `orszag` = \"Madagaszkár\";";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            return mdr;
        }
    }
}
