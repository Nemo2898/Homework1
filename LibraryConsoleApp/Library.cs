using System.Collections.Generic;

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
            // Find the first empty slot; throw if the library is full.
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] is null)
                {
                    _items[i] = item;
                    _itemCount++;
                    return;
                }
            }
            throw new InvalidOperationException("Library is full.");
        }

        /// <summary>
        /// Returns an array of items that are currently
        /// available for lending (ILendable.IsAvailable == true).
        /// </summary>
        public LibraryItem[] GetAvailableItems()
        {
            // 'i is ILendable' also skips null slots; only items that
            // signed the contract and are not currently lent pass through.
            var result = new List<LibraryItem>();
            foreach (var i in _items)
            {
                if (i is ILendable lendable && lendable.IsAvailable)
                    result.Add(i);
            }
            return result.ToArray();
        }

        /// <summary>
        /// Finds an item by its title. Returns null if the
        /// item is not found.
        /// </summary>
        public LibraryItem? FindByTitle(string title)
        {
            // Compare titles one by one; honestly return null when not found.
            foreach (var i in _items)
            {
                if (i is not null && i.Title == title)
                    return i;
            }
            return null;
        }
    }
}
