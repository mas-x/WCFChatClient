using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.Windows;
using WCFChatClient.ServiceReference1;

namespace WCFChatClient
{
    public class ChatService : IChatServiceCallback
    {
        public ObservableCollection<string> Users { get; set; }
        public ObservableCollection<string> Messages { get; set; }
        public ChatServiceClient Client { get; set; }

        public string UserName { get; set; }
        public bool IsConnected { get; private set; }

        public void OnReceiveMessage(string message)
        {
            Application.Current.Dispatcher.BeginInvoke(new Action(() => Messages.Add(message)));
        }

        public void OnUserJoined(string username)
        {
            Application.Current.Dispatcher.BeginInvoke(new Action(() => Users.Add(username)));
        }

        public bool Connect(string username)
        {
            bool result = Client.Connect(username);
            if (result)
                UserName = username;
            IsConnected = result;

            return result;
        }

        public void SendMessage(string message)
        {
            if (IsConnected)
                Client.SendMessage(UserName, message);

        }

        public ChatService()
        {
            Client = new ChatServiceClient(new InstanceContext(this));
            Messages = new ObservableCollection<string>();
            Users = new ObservableCollection<string>(Client.GetCurrentlyJoinedUsers());
        }
    }
}
