using System;
using System.Diagnostics;
using csharptest;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var libraryCatalog = new Book[]
            {
                new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
                new FictionBook("Dune", "Frank Herbert", 412, "Sience Fiction"),
                new NonFictionBook("Sapiens", "Yuva Noah Harari", 512, "History"),
                new NonFictionBook("Atomic Habits", "James Clear", 320, "Self-Help")
            };
            
            Library.DisplayBooks(libraryCatalog);
        }
    }
}