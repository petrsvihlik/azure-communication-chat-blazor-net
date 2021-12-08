using Microsoft.AspNetCore.SignalR;

namespace AcsBlazor
{
    public class ChatHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }

        public async Task ParticipantJoined()
        {
            await Clients.All.SendAsync("ParticipantJoined");
        }
    }
}
