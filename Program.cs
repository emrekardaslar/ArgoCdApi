var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { message = "Hello from .NET 8 API in Docker!" }));

app.Urls.Add("http://0.0.0.0:5041");

app.Run();
