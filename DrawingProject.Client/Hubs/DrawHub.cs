using Microsoft.AspNetCore.SignalR;

namespace DrawingProject.Client.Hubs;

public class DrawHub : Hub
{
    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId}: {message}");
    }

    public async Task NewStroke(Point start, Point end)
    {
        await Clients.Others.SendAsync("newStroke", start, end);
    }
}

