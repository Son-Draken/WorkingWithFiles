using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;        

namespace DataSet2
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

            SqlConnection connection = new SqlConnection(connectionString2);
            
            // nutno comand  pro každý table zvlášť , když snimi chci dále pracovat

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM  Category";
            SqlDataAdapter adapterCategory = new SqlDataAdapter();
            adapterCategory.SelectCommand = command;

            SqlCommand command2 = new SqlCommand();
            command2.Connection = connection;
            command2.CommandText = "SELECT * FROM Word";
            SqlDataAdapter adapterWord = new SqlDataAdapter();
            adapterWord.SelectCommand = command2;
            

            //nastaveni Datasetu pro další zpracování dat

            DataSet ds = new DataSet();
            adapterCategory.Fill(ds, "Kategorie");
            adapterWord.Fill(ds, "Slovicka");
            
            /*
            foreach (DataRow row in ds.Tables["Slovicka"].Select("CategoryId = 2", "Czech"))
                {
                Console.WriteLine(row["Czech"].ToString().PadRight(20));
                Console.WriteLine(row["Difficulty"]);
                }

            Console.WriteLine(" ");
            Console.WriteLine("Další příklad");
            Console.WriteLine(" ");
            */
          /*
            DataRelation relation = new DataRelation("relaceKategorieSlovicka",
                ds.Tables["Kategorie"].Columns["Id"],
                ds.Tables["Slovicka"].Columns["CategoryId"]);
            ds.Relations.Add(relation);

            foreach (DataRow rowCategory in ds.Tables["Kategorie"].Rows)
            {
                Console.WriteLine(rowCategory["Title"]);
                foreach (DataRow rowWord in rowCategory.GetChildRows("relaceKategorieSlovicka"))
                {
                    Console.WriteLine("   {0}", rowWord["Czech"]);
                }
            }
          */
            Console.WriteLine(" ");
            Console.WriteLine("Další příklad");
            Console.WriteLine(" ");



            //přidání nové kategorie "Rodina"

            
            DataRow newCategory = ds.Tables["Kategorie"].NewRow();
            newCategory["Title"] = "Slon";
            ds.Tables["Kategorie"].Rows.Add(newCategory);


            foreach (DataRow rowCategory in ds.Tables["Kategorie"].Rows)
            {
                Console.WriteLine(rowCategory["Title"]);
            }
            

            //odstranění kategorie např. "Rodina"
            /*
            DataRow[] deleteRow = ds.Tables["Kategorie"].Select("Title='Rodina'");
            if (deleteRow.Length !=1)
            {
                Console.WriteLine("Zaznam na smazán nenalezen");
            }
            else
            {
                DataRow row = deleteRow[0];
                row.Delete();
                Console.WriteLine("Kategorie smazána");
            }
            */

            Console.WriteLine(" ");
            Console.WriteLine("Další příklad");
            Console.WriteLine(" ");


            /* editace záznamu

            DataRow[] searchRows = ds.Tables["Slovicka"].Select("Czech='míč'");
            if (searchRows.Length != 1)
            {
                Console.WriteLine("Chyba nenalezený požadovaná záznam.");
            }
            else
            {
                DataRow row = searchRows[0];
                row.BeginEdit();
                row["Difficulty"] = 2;
                row.EndEdit();
                Console.WriteLine("změna provedena");
            }
            

            //doplnění hodnoty difficulty u slovíček bez hodnot s NULL
            /*
            DataRow[] changeRow = ds.Tables["Slovicka"].Select("Difficulty IS NULL");
            foreach (DataRow rowDif in changeRow)
            {
                DataRow row = rowDif;
                row.BeginEdit();
                row["Difficulty"] = 1;
                row.EndEdit();


            }
            Console.WriteLine("Provedeno vše");
            */


            //uložení změn, aktualizace databaze


            SqlCommandBuilder cbSlovicka = new SqlCommandBuilder(adapterWord);
            SqlCommandBuilder cbKategorie = new SqlCommandBuilder(adapterCategory);
            adapterCategory.Update(ds.Tables["Kategorie"]);
            adapterWord.Update(ds.Tables["Slovicka"]);
    
            connection.Close();
            Console.ReadKey();

           

        }
    }
}
