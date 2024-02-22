namespace GraphQL.Application.Models;

[GraphQLName("AuthorType")]
public class Author(string name)
{
    public string Name { get; set; } = name;
}

