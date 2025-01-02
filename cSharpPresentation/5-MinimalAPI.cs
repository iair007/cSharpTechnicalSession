using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace cSharpPresentation;

internal class MinimalAPI
{
    internal static void Run()
    {
        var app = WebApplication.Create(args: new[] { "http://localhost:5001" });
        app.MapGet("/", () => "Hello World!");
        app.MapGet("/greet/{name}", (string name) => $"Hello, {name}!");
        app.MapPost("/echo", (Message msg) => Results.Json(msg));

        app.Run();
    }
}
record Message(string Content);
