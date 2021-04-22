using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis.Feladatok
{
    class Feladat2
    {
        public void FeladatMegoldasA(MySqlConnection conn)
        {
            Console.WriteLine("2. Feladat: Mely országok népsűrűsége nagyobb 500 fő/km2-nél?");

            string sql = "SELECT `orszag` AS `Orszag`, `nepesseg` * 1000 / `terulet` ";
            sql += "AS `Nepsuruseg (fo/km^2)` FROM `orszagok`  WHERE `nepesseg` * 1000 / `terulet` > 500;"; 

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            Console.WriteLine();
            Console.WriteLine($"{mdr.GetName(0), -18} {mdr.GetName(1)}");
            Console.WriteLine();

            while (mdr.Read())
            {
                Console.WriteLine($"{mdr.GetValue(0),-18} {mdr.GetValue(1):F2}");
            }

            mdr.Close();

            Console.WriteLine();
        }

        public void FeladatMegoldasL(List<Orszag> lista)
        {
            Console.WriteLine("2. Feladat: Mely országok népsűrűsége nagyobb 500 fő/km2-nél?");
            Console.WriteLine();
            Console.WriteLine($"{"Ország", -18} {"Népsűrűség fő/km^2"}");
            Console.WriteLine();

            foreach (Orszag elem in lista)
            {
                double nepsuruseg = elem.Nepesseg * 1000 / elem.Terulet;

                if (nepsuruseg > 500)
                {
                    Console.WriteLine($"{elem.OrszagNeve,-18} {nepsuruseg:F2}");
                }
            }

            Console.WriteLine();
        }
    }
}
