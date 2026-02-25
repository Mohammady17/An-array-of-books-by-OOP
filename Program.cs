using System;
using System.Diagnostics;
using csharptest;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array books with different types
            var libraryCatalog = new Book[]
            {
                new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
                new FictionBook("Dune", "Frank Herbert", 412, "Sience Fiction"),
                new NonFictionBook("Sapiens", "Yuva Noah Harari", 512, "History"),
                new NonFictionBook("Atomic Habits", "James Clear", 320, "Self-Help")
            };
            var test = new FictionBook("aff", "afaf", 6565, "afdaf");
            
            // Display informations about all the books in the library
            Library.DisplayBooks(libraryCatalog);
        }
    }
}