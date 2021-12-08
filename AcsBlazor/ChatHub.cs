using Microsoft.AspNetCore.SignalR;

namespace AcsBlazor
{
    public class ChatHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
