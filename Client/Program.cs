using Microsoft.AspNetCore.SignalR.Client;
var connection = new HubConnectionBuilder().WithUrl("https://localhost:7196/myHub").WithAutomaticReconnect().Build();
connection.On<string>("message", (message) =>
{
    Console.WriteLine(message);
});
await connection.StartAsync();

Console.WriteLine(connection.State);
while (true)
{
    string? x = Console.ReadLine();
    await connection.InvokeAsync("message", x);
}