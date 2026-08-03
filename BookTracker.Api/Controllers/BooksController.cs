using Microsoft.AspNetCore.Mvc;
using BookTracker.Api.Models;
using BookTracker.Api.Services;

namespace BookTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BooksController : ControllerBase
{

    private readonly BookService _bookService;

    public BooksController(BookService bookService)
    {
        _bookService = bookService;
    }

    // status
    // private static List<Book> books = new()
    // {

    //     new Book
    //     {
    //         Id=1,
    //         Title="The Hobbit",
    //         Author="J.R.R. Tolkien",
    //         Status=BookStatus.Completed
    //     },

    //     new Book
    //     {
    //         Id=2,
    //         Title="1984",
    //         Author="George Orwell",
    //         Status= BookStatus.Completed
    //     },

    //     new Book
    //     {
    //         Id=3,
    //         Title="The Hunger Games",
    //         Author="Suzanne Collins",
    //         Status=BookStatus.Reading
    //     },
    //     new Book
    //     {
    //         Id = 4,
    //         Title="Everything Everything",
    //         Author="Nicola Yoon",
    //         Status=BookStatus.WantToRead
    //     }
    // };

    [HttpGet]
    public ActionResult<List<Book>> GetBooks()
    {
        // return Ok(books);
        return Ok(_bookService.GetBooks());
    }

    [HttpGet("id")]
    public ActionResult<Book> GetSingleBook(int id)
    {
        // var book = books.FirstOrDefault(b => b.Id == id);
        // return Ok(book);

        var book = _bookService.GetSingleBook(id);

        if (book == null)
        {
            return NotFound("This Book Does Not Exist");
        }

        return Ok(book);
    }

    [HttpGet("status")]
    public ActionResult<List<Book>> GetStatusList(BookStatus status)
    {
        // var booksWithStatus = books.Where(b => b.Status == status).ToList();

        // if (!booksWithStatus.Any())
        // {
        //     return NoContent();
        // }

        // return Ok(booksWithStatus);

        var books = _bookService.GetStatusList(status);

        if (!books.Any())
        {
            return NoContent();
        }

        return Ok(books);
    }

    [HttpPost]
    public ActionResult<Book> AddBook(Book book)
    {
        // book.Id = books.Max(b => b.Id) + 1;

        // books.Add(book);

        // return CreatedAtAction(
        //     nameof(GetBooks),
        //     new { id = book.Id },
        //     book);

        var createdBook = _bookService.AddBook(book);

        return CreatedAtAction(
            nameof(GetBooks),
            new {id = book.Id},
            book);
    }

    [HttpPut("updatestatus")]
    public IActionResult UpdateStatus(int id, BookStatus status)
    {
        // var book = books.FirstOrDefault(b => b.Id == id);

        // if (book == null)
        // {
        //     return NotFound();
        // }

        // book.Status = status;

        // return NoContent();

        var updated = _bookService.UpdateStatus(id, status);

        if (!updated)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("deletebook")]
    public IActionResult DeleteBook(int id)
    {
        // var book = books.FirstOrDefault(b => b.Id == id);

        // if (book == null)
        // {
        //     return NotFound($"No book found with {id}");
        // }

        // books.Remove(book);

        // return NoContent();

        var deletedBook = _bookService.DeleteBook(id);

        if (!deletedBook)
        {
            return NotFound();
        }

        return NoContent();
    }
}