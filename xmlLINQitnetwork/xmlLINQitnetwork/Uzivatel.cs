using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlLINQitnetwork
{
    internal class Uzivatel
    {

        public string Jmeno { get; private set; }
        public int Vek { get; private set; }
        public DateTime Registrovan { get; private set; }

        public Uzivatel(string jmeno, int vek, DateTime registrovan)
        {
            Jmeno = jmeno;
            Vek = vek;
            Registrovan = registrovan;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", Jmeno, Vek, Registrovan.ToShortDateString());
        }
    }
}
