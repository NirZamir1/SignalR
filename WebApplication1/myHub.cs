using Microsoft.AspNetCore.SignalR;

    public class myHub:Hub
    {
        public void message(string message)
        {
            Clients.Others.SendAsync("message", message) ;
        }
    }
