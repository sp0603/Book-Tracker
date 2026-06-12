using Microsoft.AspNetCore.Mvc;
using BookTracker.Api.Models;

namespace BookTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    // status
    private static List<Book> books = new()
    {

        new Book
        {
            Id=1,
            Title="The Hobbit",
            Author="J.R.R. Tolkien",
            Status=BookStatus.Completed
        },

        new Book
        {
            Id=2,
            Title="1984",
            Author="George Orwell",
            Status= BookStatus.Completed
        },

        new Book
        {
            Id=3,
            Title="The Hunger Games",
            Author="Suzanne Collins",
            Status=BookStatus.Reading
        },
        new Book
        {
            Id = 4,
            Title="Everything Everything",
            Author="Nicola Yoon",
            Status=BookStatus.WantToRead
        }
    };

    [HttpGet]
    public ActionResult<List<Book>> GetBooks()
    {
        return Ok(books);
    }

    [HttpGet("id")]
    public ActionResult<Book> GetSingleBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        return Ok(book);
    }

    [HttpGet("status")]
    public ActionResult<List<Book>> GetStatusList(BookStatus status)
    {
        var booksWithStatus = books.Where(b => b.Status == status).ToList();

        if (!booksWithStatus.Any())
        {
            return NoContent();
        }

        return Ok(booksWithStatus);
    }

    [HttpPost]
    public ActionResult<Book> AddBook(Book book)
    {
        book.Id = books.Max(b => b.Id) + 1;

        books.Add(book);

        return CreatedAtAction(
            nameof(GetBooks),
            new { id = book.Id },
            book);
    }

    [HttpPut("updatestatus")]
    public IActionResult UpdateStatus(int id, BookStatus status)
    {
        var book = books.FirstOrDefault(b => b.Id == id);

        if (book == null)
        {
            return NotFound();
        }

        book.Status = status;

        return NoContent();
    }

    [HttpDelete("deletebook")]
    public IActionResult DeleteBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);

        if (book == null)
        {
            return NotFound($"No book found with {id}");
        }

        books.Remove(book);

        return NoContent();
    }
}