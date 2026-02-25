namespace csharptest;

abstract public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public string Type { get; set; }

    public virtual void Category()
    {
    }
}
