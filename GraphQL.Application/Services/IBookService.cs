using GraphQL.Application.Models;

namespace GraphQL.Application.Services
{
    public interface IBookService
    {
        Book GetBook(string title);
    }
}
