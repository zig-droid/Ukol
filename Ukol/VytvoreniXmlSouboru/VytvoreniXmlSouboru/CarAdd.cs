using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VytvoreniXmlSouboru
{
    /// <summary>
    /// Třída pro uložení aut do lokekce
    /// </summary>
     class CarAdd
    {
        /// <summary>
        /// kolekce ve které se změní položky když se změní jinde v aplikaci
        /// </summary>
        public List<CarBazar> carBazars;
        /// <summary>
        /// inicializuji si kolekci
        /// </summary>
        protected CarAdd()
        {
            carBazars = new List<CarBazar>();
        }
        /// <summary>
        /// Přidání jednotlivých položek do kolekce, s ošetřenými vstupy od uživatele
        /// </summary>
        /// <param name="cars"></param>
        public void AddCarToList()
        {
            
            //založení auta, zadám co bude mít, jednotlivé položky
            Console.WriteLine("Zadejte model auta");
            // určí unikátní Id každému přidanému autu
            CarBazar car = new CarBazar() { CarId = Guid.NewGuid() };

            string nazevModelu;
            while (string.IsNullOrEmpty(nazevModelu = Console.ReadLine()) || !nazevModelu.StartsWith("Škoda"))
            {
                Console.WriteLine("Zadejte správný název modelu auta! ");
            }
            car.NazevModelu = nazevModelu;

            Console.WriteLine("Zadejte datum prodeje ve formátu (DD/D, MM/M, YYYY): ");
            DateTime datumProdeje;
            while (!DateTime.TryParse(Console.ReadLine(), out datumProdeje))
            {
                Console.WriteLine("Zadejte datum ve správném formátu");
            }

            car.DatumProdeje = datumProdeje;
            car.DatumProdeje.ToShortDateString();

            Console.WriteLine("Zadejte cenu auta");
            double cena;
            while (!double.TryParse(Console.ReadLine(), out cena))
            {
                Console.WriteLine("Neplatný příkaz, zadejte číslo!");
            }
            car.Cena = cena;

            Console.WriteLine("Zadejte Dph:");
            double dph;
            while (!double.TryParse(Console.ReadLine(), out dph))
            {
                Console.WriteLine("Neplatný příkaz, zadejte číslo!");
            }
            car.Dph = dph;
            // Přidám auto do kolekce
            carBazars.Add(car);
        }
    }
}
