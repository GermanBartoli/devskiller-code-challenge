using System;

using BookCrudOperationASP_Net.Data;
using System.Transactions;
using System.Collections.Generic;
using NUnit.Framework;
using System.Data.Common;
using System.Linq;
using BookCrudOperationASP_Net.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookCruBookCrudOperationASP_Net.Tests
{
    [TestFixture]
    public class BookTest
    {
        List<Book> books = null;
        private BookDbContext dbContext;

        public BookTest()
        {
            books = new List<Book>();
            List<int> id = new List<int>();
            id.Add(1);
            id.Add(2);
            id.Add(3);
            foreach (int _id in id)
                books.Add(new Book
                {
                    Title = "book1" + _id,
                    Author = "test1" + _id,
                    isbn = "isbnTest" + _id,
                    Pages = "20" + _id,
                    Publisher = "TestPublisher1" + _id
                });
        }

        [SetUp]
        public void Init()
        {
            var options = new DbContextOptionsBuilder<BookDbContext>().UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            dbContext = new BookDbContext(options);
            dbContext.Books.AddRange(books);
            dbContext.SaveChanges();
        }

        [TearDown]
        public void Dispose()
        {
            dbContext.Dispose();
        }


        [Test, Order(1)]
        public void Create()
        {
            // Arrange
            var booksController = new BooksController(new BookRepository(dbContext));
            var newBook = new Book()
            {
                isbn = Guid.NewGuid().ToString(),
                Author = Guid.NewGuid().ToString(),
                Pages = Guid.NewGuid().ToString(),
                Publisher = Guid.NewGuid().ToString(),
                Title = Guid.NewGuid().ToString()
            };

            // Act
            var result = booksController.Create(newBook) as ViewResult;

            // Verify
            Assert.AreEqual(1, dbContext.Books.Count(x => x.Id == newBook.Id && x.Author == newBook.Author));
        }

        [Test, Order(2)]
        public void GetAllBooks()
        {
            // Arrange
            var booksController = new BooksController(new BookRepository(dbContext));

            // Act
            var result = booksController.Index() as ViewResult;

            // Verify
            Assert.IsNotNull(result);
            Assert.That(result.Model, Is.InstanceOf<IEnumerable<Book>>());
            Assert.That((result.Model as IEnumerable<Book>).Count(), Is.EqualTo(3));

            foreach (var book in result.Model as IEnumerable<Book>)
            {
                Assert.AreEqual(1, dbContext.Books.Count(x => x.Id == book.Id && x.Author == book.Author));
            }
        }
        [Test, Order(3)]
        public void EditBookWithPostData()
        {
            // Arrange
            var booksController = new BooksController(new BookRepository(dbContext));
            var editedBook = books[0];
            editedBook.Title = "New title";

            // Act
            var result = booksController.Update(editedBook.Id, editedBook) as ActionResult;

            // Verify
            Assert.IsNotNull(result);
            Assert.AreEqual(1, dbContext.Books.Count(x => x.Id == editedBook.Id && x.Author == editedBook.Author));

        }

        [Test, Order(5)]
        public void DeleteBookById()
        {
            // Arrange
            var booksController = new BooksController(new BookRepository(dbContext));
            var bookToDelete = books[1];

            // Act
            var result = booksController.Delete(bookToDelete.Id) as ActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, dbContext.Books.Count(x => x.Id == bookToDelete.Id));
        }

        [Test, Order(6)]
        public void ThatCreateWithExistingISBNDoesNotCreateBook()
        {
            // Arrange
            var booksController = new BooksController(new BookRepository(dbContext));
            var newBook = books[0];

            // Act
            var result = booksController.Create(newBook);

            // Verify
            Assert.IsNotNull(result);
            Assert.AreEqual(3, dbContext.Books.Count());
            Assert.AreEqual(1, dbContext.Books.Count(x => x.isbn == newBook.isbn));
        }


    }
}