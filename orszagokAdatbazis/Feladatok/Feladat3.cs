using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis.Feladatok
{
    class Feladat3
    {
        public void FeladatMegoldasA(MySqlConnection conn)
        {
            Console.WriteLine("3. Feladat: Melyik három ország területe a legkisebb?");

            string sql = "SELECT `orszag` AS `Orszag`, `terulet` AS `Terulet km^2` FROM `orszagok` ";
            sql += "ORDER BY `terulet` LIMIT 3; ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            Console.WriteLine();
            Console.WriteLine($"{mdr.GetName(0),-18} {mdr.GetName(1)}");
            Console.WriteLine();

            while (mdr.Read())
            {
                Console.WriteLine($"{mdr.GetValue(0),-18} {mdr.GetValue(1)}");
            }

            mdr.Close();

            Console.WriteLine();
        }

        public void FeladatMegoldasL(List<Orszag> lista)
        {
            Console.WriteLine("3. Feladat: Melyik három ország területe a legkisebb?");
            Console.WriteLine();

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[j].Terulet > lista[i].Terulet)
                    {
                        Orszag t = lista[i];
                        lista[i] = lista[j];
                        lista[j] = t;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{"Ország",-18} {"Terület km^2"}");
            Console.WriteLine();
            Console.WriteLine($"{lista[0].OrszagNeve, -18} {lista[0].Terulet}");
            Console.WriteLine($"{lista[1].OrszagNeve, -18} {lista[1].Terulet}");
            Console.WriteLine($"{lista[2].OrszagNeve, -18} {lista[2].Terulet}");
        }
    }
}
