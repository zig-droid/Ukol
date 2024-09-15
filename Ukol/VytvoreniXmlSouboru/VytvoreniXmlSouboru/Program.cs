

namespace VytvoreniXmlSouboru
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            SaveCar car = new SaveCar();
            // naplním kolekci požadovanými hodnotami
            MenuItem command;
            do
            {
                // zobrazení menu
                ViewMenu();
                // zadání příkazu
                command = ReadCommand();
                // zpracování příkazu
                Console.Clear();
                switch (command)
                {
                    case MenuItem.AddItemToList:
                        car.AddCarToList();
                        break;
                    case MenuItem.SaveItemToList:
                        car.SaveCarToFile();
                        break;
                    case MenuItem.CloseApp:
                        CloseAppAction();
                        break;
                    default:
                        throw new NotImplementedException($"Nepovolený příkaz {nameof(MenuItem)} {command}");
                }

            } while (command != MenuItem.CloseApp);
            Console.WriteLine("\nAplikace se ukončuje");

            Console.ReadKey();
        }

        /// <summary>
        /// Když se zadá jiný příkaz aplikace se ukončí
        /// </summary>
        /// <returns></returns>
        private static MenuItem ReadCommand()
        {

            Console.WriteLine("Zadejte příkaz");

            string value = Console.ReadLine(); // uživatel zada text

            // naparsuji zvolene číslo které zadá uživatel
            if (!String.IsNullOrWhiteSpace(value) && Int32.TryParse(value, out int valueParsed)) // když nic nezadá uživatel zavře se aplikace
            {
                if (Enum.IsDefined(typeof(MenuItem), valueParsed))
                {
                    return (MenuItem)Enum.Parse(typeof(MenuItem), value);
                }
            }

            Console.WriteLine("Nepovolený příkaz, aplikace bude ukončena");  // chybový text
            return MenuItem.CloseApp;

        }
        /// <summary>
        /// pro ukončení aplikace
        /// </summary>
        private static void CloseAppAction()
        {
            SuccessText succes = new SuccessText();
            succes.SetText("Aplikace se ukončuje.");
        }
    }
}