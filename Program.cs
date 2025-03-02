var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { message = "Hello from .NET 8 API in Docker!" }));

// Read port from environment variable (default to 5041)
var port = Environment.GetEnvironmentVariable("PORT") ?? "5041";
app.Urls.Add($"http://0.0.0.0:{port}");

app.Run();
