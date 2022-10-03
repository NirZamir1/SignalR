using Microsoft.AspNetCore.SignalR;

    public class myHub:Hub
    {
        public void Move(string message)
        {
            Clients.Others.SendAsync("message", message) ;
        }
    }
