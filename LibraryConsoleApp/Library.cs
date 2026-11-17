namespace LibraryConsoleApp
{
    /// <summary>
    /// A library that keeps track of items.
    /// </summary>
    public class Library
    {
        private const int MaxItems = 100;

        private readonly LibraryItem?[] _items = new LibraryItem?[MaxItems];
        private int _itemCount = 0;

        /// <summary>
        /// Adds an item to the library.
        /// </summary>
        public void Add(LibraryItem item)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns an array of items that are currently
        /// available for lending (ILendable.IsAvailable == true).
        /// </summary>
        public LibraryItem[] GetAvailableItems()
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds an item by its title. Returns null if the
        /// item is not found.
        /// </summary>
        public LibraryItem? FindByTitle(string title)
        {
            // TODO: Implement.
            throw new NotImplementedException();
        }
    }
}
