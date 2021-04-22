using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis.Feladatok
{
    class Feladat1
    {
        public void FeladatMegoldasA(MySqlConnection conn)
        {
            Console.WriteLine("1. Feladat: Mi MADAGASZKÁR fővárosa?");

            string sql = "SELECT `fovaros` FROM `orszagok` WHERE `orszag` = \"Madagaszkár\";";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            Console.WriteLine();
            while (mdr.Read())
            {
                Console.WriteLine(mdr.GetValue(0));
            }

            mdr.Close();

            Console.WriteLine();
        }

        public void FeladatMegoldasL(List<Orszag> lista)
        {
            Console.WriteLine("1. Feladat: Mi MADAGASZKÁR fővárosa?");
            Console.WriteLine();

            foreach (Orszag elem in lista)
            {
                if (elem.OrszagNeve.ToLower() == "Madagaszkár".ToLower())
                {
                    Console.WriteLine(elem.Fovaros);
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
