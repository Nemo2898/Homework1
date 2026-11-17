namespace LibraryConsoleApp
{
    internal class Program
    {
        // NOTE: This demo uses the Book and Dvd classes, which are meant
        // to be implemented (e.g. as LibraryItem-based classes that
        // implement the ILendable interface). The program will not compile
        // until they are added back to the project.
        static void Main(string[] args)
        {
            var library = new Library();

            library.Add(new Book("Clean Code", 2008, "Robert C. Martin", 464));
            library.Add(new Book("The Pragmatic Programmer", 1999, "Andrew Hunt", 352));
            library.Add(new Dvd("The Matrix", 1999, 136));

            Console.WriteLine("All items available for lending:");
            PrintItems(library.GetAvailableItems());

            var item = library.FindByTitle("Clean Code");
            if (item is ILendable lendable)
            {
                Console.WriteLine();
                Console.WriteLine($"Lending: {item.Title}");
                lendable.Lend();

                Console.WriteLine("Trying to lend the same item again...");
                try
                {
                    lendable.Lend();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Items available for lending after lending:");
            PrintItems(library.GetAvailableItems());

            if (item is ILendable lendableToReturn)
            {
                Console.WriteLine();
                Console.WriteLine($"Returning: {item?.Title}");
                lendableToReturn.Return();
            }

            Console.WriteLine();
            Console.WriteLine("Items available for lending after return:");
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
