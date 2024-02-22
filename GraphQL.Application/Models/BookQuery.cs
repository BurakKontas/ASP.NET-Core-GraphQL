using GraphQL.Application.Services;
using System.Collections.Generic;

namespace GraphQL.Application.Models
{
    [QueryType]
    public class BookQuery(IBookService bookService)
    {
        public Book GetBook(string title)
        {
            return bookService.GetBook(title);
        }
    }
}
