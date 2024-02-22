using GraphQL.Application.Services;

namespace GraphQL.Application.Models
{
    [MutationType]
    public class BookMutation(IBookService bookService)
    {
        public Book AddBook(string title, int authorId)
        {
            return bookService.GetBook(title + authorId);
        }
    }
}
