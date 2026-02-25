namespace csharptest;

sealed public class NonFictionBook : Book
{
public NonFictionBook(string _title, string _author, int _pages, string _topic)
    {
        Title = _title;
        Author = _author;
        Pages = _pages;
        Topic = _topic;
    }
    
}
