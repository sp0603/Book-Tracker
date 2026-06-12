namespace BookTracker.Api.Models;

public enum BookStatus
{
    WantToRead,
    Reading,
    Completed,
    DidNotFinish
}

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public string Author { get; set; } = "";

    public BookStatus Status { get; set; }
}