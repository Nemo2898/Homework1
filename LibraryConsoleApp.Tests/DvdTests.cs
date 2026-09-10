using LibraryConsoleApp;

namespace LibraryConsoleApp.Tests
{
    public class DvdTests
    {
        [Fact]
        public void GetInfo_ReturnsExpectedInformation()
        {
            var dvd = new Dvd("The Matrix", 1999, 136);

            var info = dvd.GetInfo();

            Assert.Contains("The Matrix", info);
            Assert.Contains("1999", info);
            Assert.Contains("136", info);
        }

        [Fact]
        public void NewDvd_IsAvailableByDefault()
        {
            var dvd = new Dvd("The Matrix", 1999, 136);

            Assert.True(dvd.IsAvailable);
        }

        [Fact]
        public void Lend_MarksDvdAsUnavailable()
        {
            var dvd = new Dvd("The Matrix", 1999, 136);

            dvd.Lend();

            Assert.False(dvd.IsAvailable);
        }

        [Fact]
        public void Lend_WhenAlreadyLent_ThrowsInvalidOperationException()
        {
            var dvd = new Dvd("The Matrix", 1999, 136);
            dvd.Lend();

            Assert.Throws<InvalidOperationException>(() => dvd.Lend());
        }

        [Fact]
        public void Return_MarksDvdAsAvailableAgain()
        {
            var dvd = new Dvd("The Matrix", 1999, 136);
            dvd.Lend();

            dvd.Return();

            Assert.True(dvd.IsAvailable);
        }
    }
}
