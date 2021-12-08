using Azure.Communication.Chat;

namespace AcsBlazor.Models
{
    public class SharedState
    {
        public static ChatThreadClient ManagingChatThreadClient { get; set; }

        public static ChatThreadProperties ChatThread { get; set; }
    }
}
