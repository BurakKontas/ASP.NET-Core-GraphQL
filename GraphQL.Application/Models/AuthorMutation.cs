using GraphQL.Application.Services;

namespace GraphQL.Application.Models
{
    [MutationType]
    public class AuthorMutation(IAuthorService authorService)
    {
        public Author AddAuthor(string name)
        {
            return authorService.GetAuthor(name);
        }
    }
}