namespace csharptest;

public static class Library
{
    public static void DisplayBooks(Book[] books)
    {
        Console.Clear();
        foreach (var item in books)
        {

            Console.WriteLine("------------");
            Console.WriteLine($"Title: {item.Title}");
            Console.WriteLine($"Author: {item.Author}");
            Console.WriteLine($"Pages: {item.Pages}");
            item.Category();
            Console.WriteLine("------------");
        }
    }
}
