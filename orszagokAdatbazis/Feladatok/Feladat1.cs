using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis.Feladatok
{
    class Feladat1
    {
        public MySqlDataReader FeladatMegoldasA(MySqlConnection conn)
        {
            Console.WriteLine("1. Feladat: Mi MADAGASZKÁR fővárosa?");

            string sql = "SELECT `fovaros` FROM `orszagok` WHERE `orszag` = \"Madagaszkár\";";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            return mdr;
        }

        public void FeladatMegoldasL(List<Orszag> lista)
        {
            Console.WriteLine("1. Feladat: Mi MADAGASZKÁR fővárosa?");

            foreach (Orszag elem in lista)
            {
                if (elem.OrszagNeve.ToLower() == "Madagaszkár".ToLower())
                {
                    Console.WriteLine(elem.Fovaros);
                    break;
                }
            }
        }
    }
}
