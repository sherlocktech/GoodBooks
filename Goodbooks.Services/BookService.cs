using GoodBooks.Data;
using GoodBooks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodBooks.Services
{
    public class BookService : IBookService
    {
        private readonly GoodBooksDbContext _db;

        public BookService(GoodBooksDbContext dbContext)
        {
            _db = dbContext;
        }

        public void AddBook(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var bookToDelete = _db.Books.Find(bookId);
            if (bookToDelete != null)
            {
                _db.Remove(bookToDelete);
            }
            else
            {
                throw new InvalidOperationException("Cannot find book to delete.");
            }
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public Book GetBook(int bookId)
        {
            return _db.Books.Find(bookId);
        }
    }
}
