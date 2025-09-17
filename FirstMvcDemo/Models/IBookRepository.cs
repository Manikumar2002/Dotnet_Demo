 
namespace FirstMvcDemo.Models
{
    public class IBookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource();
        }

        public Book GetBookById(int id)
        {
            return  DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Book> SearchBooks(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book(){Id =1,Title="Mvc", Author = "Nitish"},
                new Book(){Id =2,Title="Java", Author = "Nith"},
                new Book(){Id =3,Title="Php", Author = "Nish"},
                new Book(){Id =4,Title="Mvc", Author = "Nitih"},
            };
        }

    }
}
