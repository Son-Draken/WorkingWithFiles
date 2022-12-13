using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.net_databaze_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varianta 1 vytvoření connectionStringu
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = @"(localdb)\MSSQLLocalDB";  //umístění databáze
            csb.InitialCatalog = "KopieDatabaze";   //název databaze
            csb.IntegratedSecurity = true;
            string connectionString = csb.ConnectionString;

            //varianta 2 vytvoření connectionStringu z properties dané databáze
            string connectionString2 = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = KopieDatabaze; Integrated Security = True";

            //varianta 3 vytvoření connectionStringu v případě připojení přes "Data Sources"
            //string connectionString3 = Properties.Settings.Default.KopieDatabazeConnectionString;

            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            {
                pripojeni.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = pripojeni;
                command.CommandText = "SELECT COUNT(*) FROM Word"; 
                int nuberWord = (int)command.ExecuteScalar();
                pripojeni.Close();
                Console.WriteLine("Počet sovíček je {0}", nuberWord);
            }
            Console.ReadKey();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Id, Czech, English FROM Word", connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())  //dokud neprojde všechny záznamy - čte řádek po řádku
                {
                    Console.WriteLine("{0} {1} {2}",        // lze použít několik zápisů 
                        dataReader[0],                      // index sloupce (Id)
                        dataReader["Czech"],                // index sloupce (název)
                        dataReader.GetString(2));           // index sloupce (En) s převedením na datový typ
                }
            }
            Console.ReadKey();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open ();

                Console.WriteLine("Zadej anglické slovíčko k překladu: ");
                string word = Console.ReadLine();

                SqlCommand command = new SqlCommand ("SELECT Czech FROM Word WHERE English=@word", connection);
                command.Parameters.AddWithValue("@word", word);

                SqlDataReader dataReader = command.ExecuteReader ();
                
               // while (dataReader.Read())
                //{
                    if (dataReader.Read())
                    {
                        Console.WriteLine("Překlad: {0}", dataReader["Czech"]);
                    }
                   
                    else
                    {
                        Console.WriteLine("Záznam nenalezen");
                    }
               // }
                Console.ReadKey();
            }
        }
    }
}
