using GraphQL.Application.Models;

namespace GraphQL.Application.Services
{
    public interface IAuthorService
    {
        Author GetAuthor(string name);
    }
}
