using GraphQL.Application.Models;
using GraphQL.Application.Services;
using HotChocolate.Types.Pagination;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType()
        .AddTypeExtension<AuthorQuery>()
        .AddTypeExtension<BookQuery>()
    .AddMutationType()
        .AddTypeExtension<AuthorMutation>()
        .AddTypeExtension<BookMutation>()
    .AddTypeExtension<Author>()
    .AddTypeExtension<Book>()
    .AddFiltering()
    .AddSorting()
    .SetPagingOptions(new PagingOptions { DefaultPageSize = 20});

var app = builder.Build();

app.UseHttpsRedirection();

// CORS policy ekleme
app.UseCors(policy =>
{
    policy.AllowAnyOrigin(); // İsteği herhangi bir origin'den kabul et
    policy.AllowAnyMethod(); // İsteği herhangi bir HTTP metodu ile kabul et
    policy.AllowAnyHeader(); // İsteği herhangi bir HTTP başlığı ile kabul et
});

app.MapGraphQL();

app.Run();
