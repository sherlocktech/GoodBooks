using GoodBooks.Data.Models;
using System.Collections.Generic;

namespace GoodBooks.Data
{
    public interface IBooksService
    {
        public List<BooksService> GetAllBooks();
        public Book GetBook(int bookId);
        public void AddBook(Book book);
        public void DeleteBook(int bookId);
    }
}