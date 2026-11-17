namespace LibraryConsoleApp
{
    /// <summary>
    /// Abstract base class for all library items.
    /// </summary>
    public abstract class LibraryItem
    {
        public string Title { get; set; }

        public int Year { get; set; }

        protected LibraryItem(string title, int year)
        {
            Title = title;
            Year = year;
        }

        /// <summary>
        /// Returns the item's information in a human-readable format.
        /// TODO: Implement in subclasses.
        /// </summary>
        public abstract string GetInfo();
    }
}
