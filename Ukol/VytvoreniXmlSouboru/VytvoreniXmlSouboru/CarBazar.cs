using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VytvoreniXmlSouboru
{
    /// <summary>
    /// Třída která obsahuje vlastnosti(atributy)
    /// </summary>
    public struct CarBazar
    {
        /// <summary>
        /// Určí Identifikační číslo auta
        /// </summary>
        public Guid CarId {  get; set; }
        /// <summary>
        /// Název modelu auta
        /// </summary>
        public string NazevModelu { get; set; }
        /// <summary>
        /// Kdy bylo prodáno
        /// </summary>
        public DateTime DatumProdeje { get; set; }
        /// <summary>
        /// Cena automobilu
        /// </summary>
        public double Cena { get; set; }
        /// <summary>
        /// Dph
        /// </summary>
        public double Dph { get; set; }
    }
}
