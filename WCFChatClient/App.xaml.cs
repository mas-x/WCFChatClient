using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows;
using WCFChatClient.ServiceReference1;

namespace WCFChatClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {
        public ChatService Service { get; set; }

        public App()
        {
            Service = new ChatService();
        }
    }
}
