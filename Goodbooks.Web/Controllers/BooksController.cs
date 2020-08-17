using GoodBooks.Data.Models;
using GoodBooks.Services;
using GoodBooks.Web.RequestModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace GoodBooks.Web.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBookService _bookService;

        public BooksController(ILogger<BooksController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet("/api/books/")]
        public ActionResult GetBooks()
        {
            var books = _bookService.GetAllBooks();

            return Ok(books);
        }

        [HttpPost("/api/books/")]
        public ActionResult CreateBook([FromBody] NewBookRequest bookRequest)
        {
            var now = DateTime.UtcNow;
            var book = new Book
            {
                CreatedOn = now,
                UpdatedOn = now,
                Title = bookRequest.Title,
                Author = bookRequest.Author
            };

            _bookService.AddBook(book);

            return Ok($"Book created: {book.Title}");
        }
    }
}
