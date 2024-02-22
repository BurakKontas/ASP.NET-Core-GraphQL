using GraphQL.Application.Services;
using System.Collections.Generic;

namespace GraphQL.Application.Models
{
    [QueryType]
    public class AuthorQuery(IAuthorService authorService)
    {
        public Author GetAuthor(string name)
        {
            return authorService.GetAuthor(name);
        }

        [UsePaging]
        [UseFiltering]
        [GraphQLName("authors")]
        public IEnumerable<Author> GetAllAuthors()
        {
            var authors = new List<Author>();
            for(var i = 0; i < 200; i++)
            {
                authors.Add(authorService.GetAuthor($"Author {i}"));
            }
            return authors.AsQueryable();
        }
    }
}
