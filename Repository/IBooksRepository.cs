using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookCrudOperationASP_Net.Data
{
    public interface IBooksRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);      
        bool AddBook(Book book);      
        bool UpdateBook(Book book);
        bool DeleteBook(int id);
    }
}