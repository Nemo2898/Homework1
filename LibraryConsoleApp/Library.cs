namespace LibraryConsoleApp
{
    /// <summary>
    /// Kirjasto, joka pitää kirjaa nimikkeistä.
    /// </summary>
    public class Library
    {
        private const int MaxItems = 100;

        private readonly LibraryItem?[] _items = new LibraryItem?[MaxItems];
        private int _itemCount = 0;

        /// <summary>
        /// Lisää nimikkeen kirjastoon.
        /// </summary>
        public void Add(LibraryItem item)
        {
            // TODO: Toteuta.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Palauttaa taulukon nimikkeistä, jotka ovat tällä hetkellä
        /// lainattavissa (ILendable.IsAvailable == true).
        /// </summary>
        public LibraryItem[] GetAvailableItems()
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
