using FirstMvcDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository =null;
        public BookController()
        {
            _bookRepository = new IBookRepository();
        }
        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
        public Book GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<Book> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBooks(bookName,authorName);
        }
    }
}
