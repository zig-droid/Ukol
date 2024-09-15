
namespace VytvoreniXmlSouboru
{
    internal partial class Program
    {
        /// <summary>
        /// Výčtový typ položek menu
        /// </summary>
        enum MenuItem
        {
            None = 0,
            AddItemToList = 1,
            SaveItemToList = 2,
            CloseApp = 3,
        }
        /// <summary>
        /// bere číslo položky z MenuItem text, který zadám do ViewMenu
        /// </summary>
        /// <param name="menuItem"></param>
        /// <param name="itemName"></param>
        private static void ViewMenuItem(MenuItem menuItem, string itemName)
        {
            Console.WriteLine($"{(int)menuItem} {itemName}");
        }
        /// <summary>
        /// Zobrazení položek seznamu, v hlavním programu v Main
        /// </summary>
        private static void ViewMenu()
        {
            ViewMenuItem(MenuItem.AddItemToList, "Přidat auto do seznamu");
            ViewMenuItem(MenuItem.SaveItemToList, "Uložit auto do seznamu");
            ViewMenuItem(MenuItem.CloseApp, "Ukončit aplikaci");
        }
    }
}