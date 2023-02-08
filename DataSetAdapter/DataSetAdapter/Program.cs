using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataSetAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //connection string varinata 1
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = KopieDatabaze; Integrated Security = True";

            //conection string varinata 2
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = @"(localdb)\MSSQLLocalDB";  //umístění databáze
            csb.InitialCatalog = "KopieDatabaze";   //název databaze
            csb.IntegratedSecurity = true;
            string connectionString2 = csb.ConnectionString;




            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Word";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                using (DataSet result = new DataSet())
                {
                    adapter.Fill(result);


                    foreach (DataRow row in result.Tables[0].Rows)
                    {
                        Console.WriteLine("Id: "+ row[0] + ", česky: " + row[1] + ", anglicky: " + row[2]);
                    }
                }
                connection.Close();
                Console.ReadKey();
            */
            string repeat = "yes";
            while (repeat == "yes")
            { 
                using (SqlConnection connection = new SqlConnection(connectionString2))
            
              
                {
                    connection.Open();

                    Console.WriteLine("Zadej slovíčko na překlad:");
                    string word = Console.ReadLine().ToLower();
                    string query = "SELECT * FROM Word WHERE English=@word OR Czech=@word";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    using (DataSet result = new DataSet())
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@word", word);
                        adapter.Fill(result);

                        Console.WriteLine("Zadal jste slovo: "+ word);

                        if (result.Tables[0].Rows.Count != 0)
                        {
                            if (result.Tables[0].Rows[0]["English"].Equals(word))
                            Console.WriteLine("Překlad je: {0}", result.Tables[0].Rows[0]["Czech"]);
                            else
                            Console.WriteLine("Překlad je: {0}", result.Tables[0].Rows[0]["English"]);
                        }
                        else
                        {
                            Console.WriteLine("Záznam nenalezen");
                        }
                    }

                    Console.WriteLine("Chcete pokračovat: yes/no ?");
                    Console.Write("Zadejte vaší volbu: ");
                    repeat = Console.ReadLine().ToLower();
                    
                }
             
            }
            Console.WriteLine("Děkuji za použití překladače...sbohem");
            Console.ReadKey();
        }
    }
}
