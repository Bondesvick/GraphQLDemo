//namespace GraphQLDemo
//{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.MapGraphQL("/graphql");

app.Run();
    //    }
    //}

public class Query
{
    public string Hello(string name = "World") => $"Hello, {name}";

    public IEnumerable<Book> GetBooks()
    {
        var author = new Author("Jon Skeet");
        yield return new Book("C# in Depth", author);
        yield return new Book("C# in Depth 2nd Edition", author);

    }
}

public record Book(string Title, Author Author);
public record Author(string Name);
//}