using System;
using System.Security.Cryptography.X509Certificates;

namespace LibraryConsoleApp
{
    public class Book : LibraryItem, ILendable
    {
        public string Author { get; }
        public int Pages { get; }

        private bool _isLent;

        public Book(string title, int year, string author, int pages)
            : base(title, year)
        {
            Author = author;
            Pages = pages;
        }

        public bool IsAvailable => Pages > 0;

        public void Lend()
        {
            if (_isLent)
            {
                throw new InvalidOperationException("Book is already in lent state");
            }
            _isLent = true;
        }
        public void Return()
        {
            _isLent = false;
        }

        public override string GetInfo()
        {
            return $"{Title} - {Author} - {Pages} pages";
        }
    }    
    
}