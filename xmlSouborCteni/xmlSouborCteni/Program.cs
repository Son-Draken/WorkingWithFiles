using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xmlSouborCteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Uzivatel> uzivatele = new List<Uzivatel>();


            using (XmlReader xr = XmlReader.Create(@"soubor.xml"))
            {
                string jmeno = "";
                int vek = 0;
                DateTime registrovan = DateTime.Now;
                string element = "";


                while (xr.Read())
                {



                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        element = xr.Name;
                        if (element == "uzivatel")
                        {
                            vek = int.Parse(xr.GetAttribute("vek"));
                        }

                    }

                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        switch(element)
                        {
                            case "jmeno":
                                jmeno = xr.Value;
                                break;
                            case "registrovan":
                                registrovan = DateTime.Parse(xr.Value);
                                break;
                        }
                    }
                    else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name =="uzivatel"))
                        uzivatele.Add(new Uzivatel(jmeno,vek,registrovan));
                }
            }

            


              foreach (Uzivatel u in uzivatele)
               {
                   Console.WriteLine(u);
               } 
            Console.ReadKey();
         

           
        }
    }
}
