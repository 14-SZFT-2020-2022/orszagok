using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
            /*
            MySqlDataReader mdr_1 = new Feladat1().FeladatMegoldas(conn);

            while (mdr_1.Read())
            {
                Console.WriteLine(mdr_1.GetValue(0));
            }

            mdr_1.Close();

            MySqlDataReader mdr_2 = new Feladat2().FeladatMegoldas(conn);

            Console.WriteLine($"{mdr_2.GetName(0),-15} {mdr_2.GetName(1)}");

            while (mdr_2.Read())
            {
                Console.WriteLine($"{mdr_2.GetValue(0), -15} {mdr_2.GetValue(1)}");
            }
            */

            List<Orszag> lista = new Feladat().FeladatMegoldas(conn);
            new Feladat1().FeladatMegoldasL(lista);
            new Feladat2().FeladatMegoldasL(lista);

            conn.Close();

            Console.ReadKey(true);
        }
    }
}
