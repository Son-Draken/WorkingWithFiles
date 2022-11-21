using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVsoubory
{
    internal class Databaze
    {
        private List<Uzivatel> uzivatele;
        private string soubor;

        public Databaze(string soubor)
        {
            uzivatele = new List<Uzivatel>();
            this.soubor = soubor;
        }

        public void PridejUzivatele(string jmeno, int vek, DateTime registrovan)
        {
            Uzivatel u = new Uzivatel(jmeno, vek, registrovan);
            uzivatele.Add(u);
        }
        public Uzivatel[] VratVsechny()
        { 
            return uzivatele.ToArray();
        
        }

        public void Uloz()
        {
            using (StreamWriter sw = new StreamWriter(soubor))
            {
                foreach (Uzivatel u in uzivatele)
                {
                    string[] hodnoty = { u.Jmeno.Replace(";", " "), u.Vek.ToString(), u.Registrovan.ToShortTimeString() };
                    string radek = String.Join(";", hodnoty);
                    sw.WriteLine(radek);
                }
                sw.Flush();
            }

        }

        public void Nacti()
        {
            uzivatele.Clear();
            using (StreamReader sw = new StreamReader(soubor))
            {
                string s;
                while ((s = sw.ReadLine()) != null)
                {
                    string[] rozdeleno = s.Split(';');
                    string jmeno = rozdeleno[0];
                    int vek = int.Parse(rozdeleno[1]);
                    DateTime registrovan = DateTime.Parse(rozdeleno[2]);
                    PridejUzivatele(jmeno, vek, registrovan);
                }
            }

        }

    }
}
