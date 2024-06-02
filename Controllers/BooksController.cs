using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookCrudOperationASP_Net.Data;
using Microsoft.AspNetCore.Mvc;
using BookCrudOperationASP_Net.Models;

namespace BookCrudOperationASP_Net.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Obtener todos los libros del repositorio
            var books = _booksRepository.GetAllBooks();

            // Devolver la vista con la lista de libros
            return View(books);
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _booksRepository.GetAllBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                if (_booksRepository.AddBook(book))
                {
                    // El libro se creó correctamente, puedes redirigir a una página de éxito o realizar alguna otra acción
                    return RedirectToAction("Index");
                }
                else
                {
                    // Hubo un error al crear el libro, podrías manejar el error de alguna manera (por ejemplo, mostrar un mensaje de error)
                    ModelState.AddModelError(string.Empty, "Error al crear el libro.");
                    return View(book);
                }
            }
            // Si el modelo no es válido, vuelve a mostrar el formulario con errores
            return View(book);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = _booksRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound(); // Si no se encuentra el libro, devuelve un error 404
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Book objBook)
        {
            if (id != objBook.Id)
            {
                return BadRequest(); // Si el id en la ruta no coincide con el id del libro, devuelve un error 400
            }

            if (!ModelState.IsValid)
            {
                return View(objBook); // Si el modelo no es válido, vuelve a la vista de actualización con los errores del modelo
            }

            try
            {
                _booksRepository.UpdateBook(objBook);
                return RedirectToAction(nameof(Index)); // Si la actualización es exitosa, redirige al método Index
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Book update failed"); // Si ocurre un error durante la actualización, agrega un error al ModelState
                return View(objBook); // Vuelve a la vista de actualización con el modelo y el estado del modelo actualizado
            }
        }

        public IActionResult Delete(int id)
        {
            var isDeleted = _booksRepository.DeleteBook(id);
            if (isDeleted)
            {
                return Ok(true); // Retorna true si se eliminó correctamente
            }
            else
            {
                return NotFound(false); // Retorna false si el libro no existe
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
