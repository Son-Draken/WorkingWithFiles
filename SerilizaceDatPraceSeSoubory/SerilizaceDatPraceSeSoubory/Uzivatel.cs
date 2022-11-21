using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilizaceDatPraceSeSoubory
{
    public class Uzivatel
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

       /*
        public Uzivatel(string jmeno, string prijmeni, DateTime datumNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
        }
       */
       

        public override string ToString()
        {
            return "jméno: " + Jmeno + " Příjmení: " + Prijmeni + " Datum narození: " + DatumNarozeni.ToLongDateString();
        }

    }
}
