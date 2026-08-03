using BookTracker.Api.Controllers;
using BookTracker.Api.Models;
using BookTracker.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookTracker.Api.Tests;

public class UnitTest1
{

    //Arrange, Act, Assert

    [Fact]

    // should get all the books in the list
    public void GetBooks_ShouldReturnAll()
    {
        // arrange
        var service = new BookService();

        // act
        var books = service.GetBooks();

        // assert
        Assert.NotNull(books);
    }

    [Fact]
    public void GetSingleBook_ShouldReturnOne()
    {
        // arrange
        var service = new BookService();

        // act 
        var book = service.GetSingleBook(2);

        // assert
        Assert.NotNull(book);
    }

    [Fact]
    public void GetStatusList_ShouldReturnWantToRead()
    {
        // arrange
        var service = new BookService();

        // act
        var books = service.GetStatusList(BookStatus.WantToRead);

        // assert
        Assert.NotEmpty(books);
        Assert.NotNull(books);

    }

    [Fact]

    public void GetStatusList_ShouldNotReturnDidNotFinish()
    {
        // arrange
        var service = new BookService();

        // act
        var books = service.GetStatusList(BookStatus.DidNotFinish);

        // assert -> expecting an empty list of books for did not finish
        Assert.Empty(books);
        Assert.NotNull(books);
    }

    [Fact]
    public void GetStatusList_ShouldReturnCompleted()
    {
        // arrange
        var service = new BookService();

        // act
        var books = service.GetStatusList(BookStatus.Completed);

        // assert
        Assert.NotEmpty(books);
        Assert.NotNull(books);
    }

    [Fact]
    public void GetStatusList_ShouldReturnReading()
    {
        // arrange
        var service = new BookService();

        // act
        var books = service.GetStatusList(BookStatus.Reading);

        // assert
        Assert.NotEmpty(books);
        Assert.NotNull(books);
    }

    [Fact]

    public void AddBook_ShouldAddBookToBookList()
    {
        // arrange
        var service = new BookService();

        var book = new Book
        {
            Id = 5,
            Title = "The Hunger Games: Catching Fire",
            Author = "Suzanne Collins",
            Status = BookStatus.WantToRead
        };

        // act
        var addedBook = service.AddBook(book);

        // assert
        Assert.NotNull(addedBook);
    }

    [Fact]
    public void UpdateStatus_BookShouldBeUpdated()
    {
        // arrange
        var service = new BookService();

        // act
        var update = service.UpdateStatus(4, BookStatus.Completed);

        // assert
        Assert.True(update);
    }

    [Fact]

    public void DeleteBook_BookShouldDelete()
    {
        // arrange
        var service = new BookService();

        // act
        var deletedBook = service.DeleteBook(4);

        // assert
        Assert.True(deletedBook);
    }
}
