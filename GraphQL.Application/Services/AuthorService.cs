using GraphQL.Application.Models;

namespace GraphQL.Application.Services
{
    public class AuthorService: IAuthorService
    {
        public Author GetAuthor(string name)
        {
            var author = new Author(name);
            return author;
        }
    }
}
