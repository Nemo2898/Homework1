namespace LibraryConsoleApp
{
    /// <summary>
    /// Interface for lendable library items.
    /// </summary>
    public interface ILendable
    {
        /// <summary>
        /// Indicates whether the item is currently available.
        /// </summary>
        bool IsAvailable { get; }

        /// <summary>
        /// Lends the item. If the item is already lent, an
        /// InvalidOperationException is thrown.
        /// </summary>
        void Lend();

        /// <summary>
        /// Returns the item to the library.
        /// </summary>
        void Return();
    }
}
