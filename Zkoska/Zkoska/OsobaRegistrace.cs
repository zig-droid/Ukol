using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zkoska
{
    class OsobaRegistrace
    {
        public string Jmeno {  get; set; }
        public string Prijmeni {  get; set; }
        public string Prezdivka {  get; set; }
        public string Heslo {  get; set; }
        public OsobaRegistrace(string jmeno, string prijmeni, string prezdivka, string heslo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Prezdivka = prezdivka;
            Heslo = heslo;
        }
    }
}
