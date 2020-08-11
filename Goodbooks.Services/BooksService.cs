using GoodBooks.Data.Models;
using System;
using System.Collections.Generic;

namespace GoodBooks.Data
{
    public class BooksService : IBooksService
    {
        private readonly GoodBooksDbContext _dbContext;

        public BooksService(GoodBooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public List<BooksService> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
