var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.Run(async (HttpContext context) =>
{
    context.Response.StatusCode = 200;

    context.Response.Headers["MyKey"] = "my value";
    context.Response.Headers["Server"] = "My Server";

    await context.Response.WriteAsync("Hello");
    await context.Response.WriteAsync(" World!");
});

app.Run();

