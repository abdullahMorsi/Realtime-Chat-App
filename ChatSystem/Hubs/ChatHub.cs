using ChatSystem.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatSystem.Hubs
{
    public class ChatHub:Hub
    {

        [HubMethodName("sendmessage")]
        public void sendMessage(Message msg)
        {
            msg.time = DateTime.Now;
            Clients.Caller.SendAsync("mymessage", msg);
            Clients.Others.SendAsync("others", msg);
        }
        public void istyping(string name)
        {
            Clients.Others.SendAsync("istypingmsg", name);
        }
        public void nottyping()
        {
            Clients.Others.SendAsync("nottypingmsg");
        }

        public void joinGroup(string connectionId, string groupName)
        {
            Groups.AddToGroupAsync(connectionId, groupName);
        }
    }
}
