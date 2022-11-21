using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xmlDOMcteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("soubor.xml");

            XmlNode root = doc.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "uzivatel")
                {
                    XmlElement uzivatel = (XmlElement)node;
                    int vek = int.Parse(uzivatel.GetAttribute("vek"));
                    string jmeno = uzivatel.GetElementsByTagName("jmeno")[0].InnerText;
                    DateTime registrovan = DateTime.Parse(uzivatel.GetElementsByTagName("registrovan")[0].InnerText);
                    Uzivatel u = new Uzivatel(jmeno, vek, registrovan);
                    Console.WriteLine(u);
                }
            }



        }
    } 
}
