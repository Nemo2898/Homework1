namespace LibraryConsoleApp
{
    /// <summary>
    /// Abstrakti kantaluokka kaikille kirjaston nimikkeille.
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
        /// Palauttaa nimikkeen tiedot ihmisluettavassa muodossa.
        /// TODO: Toteuta aliluokissa.
        /// </summary>
        public abstract string GetInfo();
    }
}
