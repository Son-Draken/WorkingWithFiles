using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlLINQitnetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Uzivatel> uzivatele = new List<Uzivatel>();
            uzivatele.Add(new Uzivatel("Jan Novák", 22, new DateTime(1980, 1, 1)));
            uzivatele.Add(new Uzivatel("Tomáš Marný", 22, new DateTime(1984, 2, 5)));
            uzivatele.Add(new Uzivatel("Jan Nový", 22, new DateTime(1988, 3, 8)));

            XDocument dokument = new XDocument(
                new XDeclaration("1.0", "UTF-8", null),  //nutna deklarace ...vždy
                new XElement("uzivatele",
                    uzivatele.Select(u => new XElement("uzivatel",
                        new XAttribute("vek", u.Vek),
                        new XElement("jmeno", u.Jmeno),
                        new XElement("registrovan", u.Registrovan))
                        ))
                );

            dokument.Save("uzivatele1.xml");

        
            foreach (XElement u in dokument.Element("uzivatele").Elements("uzivatel"))
            {
                Console.WriteLine(u.Element("jmeno").Value);
            }

            Console.WriteLine(" ");
            

         
            foreach (XElement u in dokument.Element("uzivatele").Elements("uzivatel"))
            {
                Console.WriteLine(u.Attribute("vek") + " " + u.Element("jmeno").Value + " " + u.Element("registrovan").Value); 
            }

            Console.WriteLine(" ");

            var dotaz = from u in dokument.Element("uzivatele").Elements("uzivatel")
                        where u.Element("jmeno").Value.StartsWith("Jan")
                        select u;

            //Editace údajů
            foreach (XElement u in dotaz)
            {
                u.Attribute("vek").Value = "31";
            }
            dokument.Save("uzivatele2.xml");
            // vypis  ....nevypisuje 1 uzivatele
            foreach (XElement u in dokument.Element("uzivatele").Elements("uzivatel"))
            {
                Console.WriteLine(u.NextNode);
            }

            //mazani
            (from u in dokument.Element("uzivatele").Elements("uzivatel")
             where int.Parse(u.Attribute("vek").Value) < 25
             select u).Remove();
            dokument.Save("uzivatele4.xml");




        }
    }
}
