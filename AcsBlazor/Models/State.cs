using Azure.Communication;
using Azure.Communication.Chat;

namespace AcsBlazor.Models
{
    public class State
    {
        public string Name = string.Empty;

        public CommunicationUserIdentifier User { get; set; }

        public ChatClient ChatClient { get; set; }

        public ChatThreadClient ChatThreadClient { get; set; }

        public bool Initialized { get; set; }
    }
}
