using LibraryConsoleApp;

namespace LibraryConsoleApp.Tests
{
    public class LibraryTests
    {
        [Fact]
        public void Add_AddsItemToLibrary()
        {
            var library = new Library();
            var book = new Book("Clean Code", 2008, "Robert C. Martin", 464);

            library.Add(book);

            Assert.Equal(book, library.FindByTitle("Clean Code"));
        }

        [Fact]
        public void FindByTitle_WhenItemDoesNotExist_ReturnsNull()
        {
            var library = new Library();

            var result = library.FindByTitle("Does not exist");

            Assert.Null(result);
        }

        [Fact]
        public void GetAvailableItems_ReturnsOnlyAvailableItems()
        {
            var library = new Library();
            var availableBook = new Book("Clean Code", 2008, "Robert C. Martin", 464);
            var lentDvd = new Dvd("The Matrix", 1999, 136);
            lentDvd.Lend();

            library.Add(availableBook);
            library.Add(lentDvd);

            var availableItems = library.GetAvailableItems();

            Assert.Contains(availableBook, availableItems);
            Assert.DoesNotContain(lentDvd, availableItems);
        }
    }
}
