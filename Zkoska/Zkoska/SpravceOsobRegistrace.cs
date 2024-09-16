using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zkoska
{
    internal class SpravceOsobRegistrace
    {
        /// <summary>
        /// List speciální, přístup že se změní položky z jakekoliv části programu?
        /// </summary>
        public BindingList<OsobaRegistrace> OsobaRegistraces {  get; set; }

        public SpravceOsobRegistrace() => OsobaRegistraces = new BindingList<OsobaRegistrace>(); 
        /// <summary>
        /// pro registraci uživatele
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="prezdivka"></param>
        /// <param name="heslo"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Registruj(string jmeno, string prijmeni, string prezdivka, string heslo)
        {
            if (jmeno == null) throw new ArgumentNullException("Zadej jméno");
            if (prijmeni == null) throw new ArgumentNullException("Zadej příjmení");
            if (prezdivka == null) throw new ArgumentNullException("Zadej přezdívku");
            if (heslo == null) throw new ArgumentNullException("Zadej heslo");
            OsobaRegistrace osobaRegistrace = new OsobaRegistrace(jmeno,prijmeni,prezdivka,heslo);
            OsobaRegistraces.Add(osobaRegistrace);
        }
        /// <summary>
        /// Metoda pro smazání uživatele
        /// </summary>
        /// <param name="osobaRegistrace"></param>
        public void Smaz(OsobaRegistrace osobaRegistrace) => OsobaRegistraces.Remove(osobaRegistrace);
    }
}
