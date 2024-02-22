using GraphQL.Application.Models;

namespace GraphQL.Application.Services
{
    public class BookService: IBookService
    {
        public Book GetBook(string title)
        {
            // Örnek bir yazar oluştur
            var author = new Author("AuthorName");

            // Kitap oluştur ve döndür
            var book = new Book(title, author);
            return book;
        }
    }
}
