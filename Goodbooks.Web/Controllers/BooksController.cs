using GoodBooks.Data.Models;
using GoodBooks.Services;
using GoodBooks.Web.RequestModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace GoodBooks.Web.Controllers
{
    [Route("/api/[controller]/")]
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

        [HttpGet]
        public ActionResult GetBooks()
        {
            var books = _bookService.GetAllBooks();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult GetBookById(int id)
        {
            var book = _bookService.GetBook(id);

            return Ok(book);
        }

        [HttpPost]
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

        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);

            return Ok($"Book under id {id} deleted.");
        }
    }
}
