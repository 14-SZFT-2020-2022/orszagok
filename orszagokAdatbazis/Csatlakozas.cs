using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace orszagokAdatbazis
{
    class Csatlakozas
    {
        public string Adatbazis { get; set; }

        public Csatlakozas(string adatbazis)
        {
            this.Adatbazis = adatbazis;
        }

        public MySqlConnection Felcsatlakozas()
        {
            string kapcsolodo = $"server=localhost;port=3307;username=root;password=;database={this.Adatbazis}";
            MySqlConnection conn = new MySqlConnection(kapcsolodo);

            try
            {
                conn.Open();
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Nincsen nyitott stream!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nem sikerült a csatlakozás!");
                Console.WriteLine(ex.Message);
            }

            return conn;
        }
    }
}
