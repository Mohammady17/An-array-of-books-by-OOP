namespace csharptest;

sealed public class FictionBook : Book
{
    public FictionBook(string _title, string _author, int _pages, string _genre)
    {
        Title = _title;
        Author = _author;
        Pages = _pages;
        Type = _genre;
    }

    public override void Category()
    {
        Console.WriteLine($"Genre: {Type}");
    }
}
