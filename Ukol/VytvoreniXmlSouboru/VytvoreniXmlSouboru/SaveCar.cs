using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VytvoreniXmlSouboru
{
    internal class SaveCar: CarAdd
    {
        /// <summary>
        /// Název souboru kam ukladat
        /// </summary>
        private const string FileName = "autobazar1.xml";

        
        public SaveCar()
        {
            
        }
        /// <summary>
        /// Uložení dat z kolekce do souboru xml
        /// </summary>
        /// <param name="cars"></param>
        public void SaveCarToFile()
        {
            
            //xml serializator položky se stanou objekty do xml
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<CarBazar>));
            var stream = new StreamWriter(FileName); // bude ukladat auta do souboru

            xmlserializer.Serialize(stream, carBazars); // list do streamu

            stream.Close();
            Console.WriteLine("Auto uloženo do souboru\n");
        }
    }
}
