var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { message = "Hello from .NET 8 API in Docker!" }));

app.Run();
