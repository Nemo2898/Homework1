namespace LibraryConsoleApp
{
    public class Dvd : LibraryItem, ILendable
    {
        public int DurationMinutes { get; }

        private bool _isLent;

        public Dvd(string title, int year, int durationMinutes)
            : base(title, year)
        {
            DurationMinutes = durationMinutes;
        }

        public bool IsAvailable => !_isLent;

        public void Lend()
        {
            if (_isLent)
            {
                throw new InvalidOperationException("Item is already lent.");
            }
            _isLent = true;
        }

        public void Return()
        {
            _isLent = false;
        }

        public override string GetInfo()
        {
            return $"{Title} ({Year}), {DurationMinutes} min";
        }
    }
}
