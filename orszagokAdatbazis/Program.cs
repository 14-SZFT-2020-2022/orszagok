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

            Feladat1 elso = new Feladat1();
            MySqlDataReader mdr = elso.FeladatMegoldas(conn);

            while (mdr.Read())
            {
                Console.WriteLine(mdr.GetValue(0));
            }


            conn.Close();

            Console.ReadKey(true);
        }
    }
}
