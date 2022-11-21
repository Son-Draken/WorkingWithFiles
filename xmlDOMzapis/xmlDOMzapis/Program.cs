using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xmlDOMzapis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Uzivatel> uzivatele = new List<Uzivatel>();
            uzivatele.Add(new Uzivatel("Pepa Novák", 22, new DateTime(1980, 1, 1)));
            uzivatele.Add(new Uzivatel("Alois Marný", 22, new DateTime(1984, 2, 5)));
            uzivatele.Add(new Uzivatel("Jan Nový", 22, new DateTime(1988, 3, 8)));



            XmlDocument doc = new XmlDocument();
            XmlDeclaration deklarace = doc.CreateXmlDeclaration("1.0", "utf-8",null);
            doc.AppendChild(deklarace);
            XmlElement koren = doc.CreateElement("uzivatel");


            foreach (Uzivatel u in uzivatele)
            {
                XmlElement uzivatel = doc.CreateElement("uzivatel");
                //atributy
                uzivatel.SetAttribute("vek", u.Vek.ToString());
                //jmeno
                XmlElement jmeno = doc.CreateElement("jmeno");
                jmeno.InnerText = u.Jmeno;
                uzivatel.AppendChild(jmeno);
                //registrovan
                XmlElement registrovan = doc.CreateElement("registrovan");
                registrovan.InnerText = u.Registrovan.ToString();
                uzivatel.AppendChild(registrovan);
                koren.AppendChild(uzivatel);

                //uložení do souboru
                doc.AppendChild(koren);

                doc.Save("soubor.xml");
            }
        }
    }
}
