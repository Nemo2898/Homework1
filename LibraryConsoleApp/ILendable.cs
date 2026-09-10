namespace LibraryConsoleApp
{
    /// <summary>
    /// Rajapinta lainattaville kirjaston nimikkeille.
    /// </summary>
    public interface ILendable
    {
        /// <summary>
        /// Kertoo, onko nimike tällä hetkellä lainattavissa.
        /// </summary>
        bool IsAvailable { get; }

        /// <summary>
        /// Lainaa nimikkeen. Jos nimike on jo lainattu, heitetään
        /// InvalidOperationException.
        /// </summary>
        void Lend();

        /// <summary>
        /// Palauttaa nimikkeen kirjastoon.
        /// </summary>
        void Return();
    }
}
