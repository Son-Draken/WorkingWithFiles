using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xmlSoubory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Uzivatel> uzivatele = new List<Uzivatel>();
            uzivatele.Add(new Uzivatel("Pavel Slavík", 22, new DateTime(2000, 3, 21)));
            uzivatele.Add(new Uzivatel("Jan Novák", 31, new DateTime(2012, 10, 30)));
            uzivatele.Add(new Uzivatel("Tomáš Marný", 16, new DateTime(2011, 1, 12)));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(@"soubor.xml", settings))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("uzivatele");

                foreach (Uzivatel u in uzivatele)
                {
                    
                    xw.WriteStartElement("uzivatel");
                    xw.WriteAttributeString("vek", u.Vek.ToString());
                   // xw.WriteEndElement();

                    xw.WriteStartElement("jmeno");
                    xw.WriteValue(u.Jmeno);
                    xw.WriteEndElement();
                    xw.WriteStartElement("registrovan");
                    xw.WriteValue(u.Registrovan.ToShortDateString());
                    xw.WriteEndElement();

                    xw.WriteEndElement();

                    /*
                    xw.WriteStartElement("jmeno");
                    xw.WriteValue(u.Jmeno);
                    xw.WriteEndElement();
                    xw.WriteStartElement("registrovany");
                    xw.WriteValue(u.Registrovan.ToShortDateString());
                    xw.WriteEndElement();
                    */
                    //lze jednoduše zapsat v případě jedné hodnoty:
                    //xw.WriteElementString("jmeno", u.Jmeno);
                    //xw.WriteElementString("registrovan", u.Registrovan.ToShortDateString());

                    /*
                    xw.WriteStartElement("uzivatel");
                    xw.WriteAttributeString("vek", u.Vek.ToString());

                    xw.WriteElementString("jmeno", u.Jmeno);
                    xw.WriteElementString("registrovan", u.Registrovan.ToShortDateString());

                    xw.WriteEndElement();
                    */
                }

                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Flush();

            }



        }
    }
}
