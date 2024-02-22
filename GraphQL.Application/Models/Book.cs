namespace GraphQL.Application.Models;

[GraphQLName("BookType")]
public class Book(string title, Author author)
{
    public string Title { get; set; } = title;

    public Author Author { get; set; } = author;
}

