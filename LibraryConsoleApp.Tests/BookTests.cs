using LibraryConsoleApp;

namespace LibraryConsoleApp.Tests
{
    public class BookTests
    {
        [Fact]
        public void GetInfo_ReturnsExpectedInformation()
        {
            var book = new Book("Clean Code", 2008, "Robert C. Martin", 464);

            var info = book.GetInfo();

            Assert.Contains("Clean Code", info);
            Assert.Contains("2008", info);
            Assert.Contains("Robert C. Martin", info);
            Assert.Contains("464", info);
        }

        [Fact]
        public void NewBook_IsAvailableByDefault()
        {
            var book = new Book("Clean Code", 2008, "Robert C. Martin", 464);

            Assert.True(book.IsAvailable);
        }

        [Fact]
        public void Lend_MarksBookAsUnavailable()
        {
            var book = new Book("Clean Code", 2008, "Robert C. Martin", 464);

            book.Lend();

            Assert.False(book.IsAvailable);
        }

        [Fact]
        public void Lend_WhenAlreadyLent_ThrowsInvalidOperationException()
        {
            var book = new Book("Clean Code", 2008, "Robert C. Martin", 464);
            book.Lend();

            Assert.Throws<InvalidOperationException>(() => book.Lend());
        }

        [Fact]
        public void Return_MarksBookAsAvailableAgain()
        {
            var book = new Book("Clean Code", 2008, "Robert C. Martin", 464);
            book.Lend();

            book.Return();

            Assert.True(book.IsAvailable);
        }
    }
}
