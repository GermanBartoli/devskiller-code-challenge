using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookCrudOperationASP_Net.Data
{
    public class BookRepository : IBooksRepository
    {
        private readonly BookDbContext _entities;

        public BookRepository(BookDbContext bookDbContext)
        {
            this._entities = bookDbContext;
        }

        public List<Book> GetAllBooks()
        {
            return _entities.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _entities.Books.FirstOrDefault(x => x.Id == id); 
        }

        public bool AddBook(Book book)
        {
            try
            {
                _entities.Books.Add(book);
                _entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateBook(Book book)
        {
            try
            {
                _entities.Books.Update(book);
                _entities.SaveChanges();
                return true; // Devuelve true si la actualización se realizó correctamente
            }
            catch (Exception)
            {
                return false; // Devuelve false si ocurrió algún error durante la actualización
            }
        }

        public bool DeleteBook(int id)
        {
            try
            {
                var bookToDelete = _entities.Books.FirstOrDefault(x => x.Id == id);
                if (bookToDelete != null)
                {
                    _entities.Books.Remove(bookToDelete);
                    _entities.SaveChanges();
                    return true; // Retorna true si se eliminó correctamente
                }
                else
                {
                    return false; // Retorna false si el libro no existe
                }
            }
            catch (Exception)
            {
                return false; // Retorna false si ocurrió algún error al intentar eliminar el libro
            }
        }
    }
}