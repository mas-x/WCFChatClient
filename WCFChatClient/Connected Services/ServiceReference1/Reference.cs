﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFChatClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IChatService", CallbackContract=typeof(WCFChatClient.ServiceReference1.IChatServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IChatService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Connect", ReplyAction="http://tempuri.org/IChatService/ConnectResponse")]
        bool Connect(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/Connect", ReplyAction="http://tempuri.org/IChatService/ConnectResponse")]
        System.Threading.Tasks.Task<bool> ConnectAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatService/SendMessage")]
        void SendMessage(string username, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatService/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(string username, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetCurrentlyJoinedUsers", ReplyAction="http://tempuri.org/IChatService/GetCurrentlyJoinedUsersResponse")]
        string[] GetCurrentlyJoinedUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService/GetCurrentlyJoinedUsers", ReplyAction="http://tempuri.org/IChatService/GetCurrentlyJoinedUsersResponse")]
        System.Threading.Tasks.Task<string[]> GetCurrentlyJoinedUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatService/OnUserJoined")]
        void OnUserJoined(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatService/OnReceiveMessage")]
        void OnReceiveMessage(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatServiceChannel : WCFChatClient.ServiceReference1.IChatService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatServiceClient : System.ServiceModel.DuplexClientBase<WCFChatClient.ServiceReference1.IChatService>, WCFChatClient.ServiceReference1.IChatService {
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool Connect(string username) {
            return base.Channel.Connect(username);
        }
        
        public System.Threading.Tasks.Task<bool> ConnectAsync(string username) {
            return base.Channel.ConnectAsync(username);
        }
        
        public void SendMessage(string username, string message) {
            base.Channel.SendMessage(username, message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string username, string message) {
            return base.Channel.SendMessageAsync(username, message);
        }
        
        public string[] GetCurrentlyJoinedUsers() {
            return base.Channel.GetCurrentlyJoinedUsers();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCurrentlyJoinedUsersAsync() {
            return base.Channel.GetCurrentlyJoinedUsersAsync();
        }
    }
}