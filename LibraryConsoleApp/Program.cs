namespace LibraryConsoleApp
{
    internal class Program
    {
        // HUOM: Tämä demo käyttää Book- ja Dvd-luokkia, jotka on tarkoitus
        // toteuttaa (esim. LibraryItem-pohjaisina, ILendable-rajapinnan
        // toteuttavina luokkina). Ohjelma ei käänny ennen kuin ne on
        // lisätty takaisin projektiin.
        static void Main(string[] args)
        {
            var library = new Library();

            library.Add(new Book("Clean Code", 2008, "Robert C. Martin", 464));
            library.Add(new Book("The Pragmatic Programmer", 1999, "Andrew Hunt", 352));
            library.Add(new Dvd("The Matrix", 1999, 136));

            Console.WriteLine("Kaikki lainattavissa olevat nimikkeet:");
            PrintItems(library.GetAvailableItems());

            var item = library.FindByTitle("Clean Code");
            if (item is ILendable lendable)
            {
                Console.WriteLine();
                Console.WriteLine($"Lainataan: {item.Title}");
                lendable.Lend();

                Console.WriteLine("Yritetään lainata sama nimike uudelleen...");
                try
                {
                    lendable.Lend();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Virhe: {ex.Message}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Lainattavissa olevat nimikkeet lainauksen jälkeen:");
            PrintItems(library.GetAvailableItems());

            if (item is ILendable lendableToReturn)
            {
                Console.WriteLine();
                Console.WriteLine($"Palautetaan: {item?.Title}");
                lendableToReturn.Return();
            }

            Console.WriteLine();
            Console.WriteLine("Lainattavissa olevat nimikkeet palautuksen jälkeen:");
            PrintItems(library.GetAvailableItems());
        }

        private static void PrintItems(IEnumerable<LibraryItem> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.GetInfo()}");
            }
        }
    }
}
