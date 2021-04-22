using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using orszagokAdatbazis.Feladatok;

namespace orszagokAdatbazis
{
    class Program
    {
        static void Main(string[] args)
        {
            Csatlakozas csatlakozas = new Csatlakozas("orszagok");
            MySqlConnection conn = csatlakozas.Felcsatlakozas();
            List<Orszag> lista = new Feladat().FeladatMegoldas(conn);

            Console.Write("Mivel dolgozzunk (a/l): ");
            char mivel = Char.Parse(Console.ReadLine());

            if (mivel == 'a')
            {
                Console.Clear();
                new Feladat1().FeladatMegoldasA(conn);
                new Feladat2().FeladatMegoldasA(conn);
                new Feladat3().FeladatMegoldasA(conn);
            }
            else if (mivel == 'l')
            {
                Console.Clear();
                new Feladat1().FeladatMegoldasL(lista);
                new Feladat2().FeladatMegoldasL(lista);
                new Feladat3().FeladatMegoldasL(lista);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ilyen betűt nem adtam meg!");
            }

            conn.Close();

            Console.ReadKey(true);
        }
    }
}
