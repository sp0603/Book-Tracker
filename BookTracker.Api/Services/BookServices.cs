using BookTracker.Api.Models;
using System.Data;

namespace BookTracker.Api.Services;

public class BookService
{
    private readonly List<Book> books = new()
    {
        new Book
        {
            Id = 1,
            Title = "The Hobbit",
            Author = "J.R.R. Tolkien",
            Status = BookStatus.Completed
        },

        new Book
        {
            Id = 2,
            Title = "1984",
            Author = "George Orwell",
            Status = BookStatus.Completed
        },

        new Book
        {
            Id = 3,
            Title = "The Hunger Games",
            Author= "Suzanne Collins",
            Status = BookStatus.Reading
        },

        new Book
        {
            Id = 4,
            Title = "Everything Everything",
            Author = "Nicola Yoon",
            Status = BookStatus.WantToRead
        }
    };

    public List<Book> GetBooks()
    {
        return books;
    }

    public Book? GetSingleBook(int id)
    {
        return books.FirstOrDefault(b => b.Id == id);
    }

    public List<Book> GetStatusList(BookStatus status)
    {
        return books.Where(b => b.Status == status).ToList();
    }

    public Book? AddBook(Book book)
    {
        book.Id = books.Max(b => b.Id) + 1;

        books.Add(book);

        return book;
    }

    public bool UpdateStatus(int id, BookStatus status)
    {
        var book = books.FirstOrDefault(b => b.Id == id);

        if(book == null)
        {
            return false;
        }

        book.Status = status;

        return true;
    }

    public bool DeleteBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);

        if (book == null)
        {
            return false;
        }

        books.Remove(book);

        return true;
    }
}