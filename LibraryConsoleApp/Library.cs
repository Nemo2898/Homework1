namespace LibraryConsoleApp
{
    /// <summary>
    /// Kirjasto, joka pitää kirjaa nimikkeistä.
    /// </summary>
    public class Library
    {
        private readonly List<LibraryItem> _items = new();

        /// <summary>
        /// Lisää nimikkeen kirjastoon.
        /// </summary>
        public void Add(LibraryItem item)
        {
            // TODO: Toteuta.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Palauttaa listan nimikkeistä, jotka ovat tällä hetkellä
        /// lainattavissa (ILendable.IsAvailable == true).
        /// </summary>
        public List<LibraryItem> GetAvailableItems()
        {
            // TODO: Toteuta.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Etsii nimikkeen otsikon perusteella. Palauttaa null, jos
        /// nimikettä ei löydy.
        /// </summary>
        public LibraryItem? FindByTitle(string title)
        {
            // TODO: Toteuta.
            throw new NotImplementedException();
        }
    }
}
