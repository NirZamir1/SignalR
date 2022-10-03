using Microsoft.Net.Http.Server;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app = builder.Build();
app.MapHub<myHub>("/myHub");
app.MapGet("/hi", () => "hello");
app.Run();
