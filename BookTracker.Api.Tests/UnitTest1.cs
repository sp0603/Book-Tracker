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
    public void GetStatusList()
    {
        // arrange
        var service = new BookService();

        // act
        var books = service.GetStatusList(BookStatus.WantToRead);

        // assert
        Assert.NotNull(books);

    }
}
