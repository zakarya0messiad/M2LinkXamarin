﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M2LinkXamarin.WebServiceClients
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/M2Link.Entities")]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ContentField;
        
        private System.Guid IdField;
        
        private System.Guid OwnerIdField;
        
        private string OwnerPseudoField;
        
        private System.DateTime PostDateField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content
        {
            get
            {
                return this.ContentField;
            }
            set
            {
                this.ContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid OwnerId
        {
            get
            {
                return this.OwnerIdField;
            }
            set
            {
                this.OwnerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OwnerPseudo
        {
            get
            {
                return this.OwnerPseudoField;
            }
            set
            {
                this.OwnerPseudoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PostDate
        {
            get
            {
                return this.PostDateField;
            }
            set
            {
                this.PostDateField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="M2LinkXamarin.WebServiceClients.IWSMessage")]
    public interface IWSMessage
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/DoWork", ReplyAction="http://tempuri.org/IWSMessage/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/DoWork", ReplyAction="http://tempuri.org/IWSMessage/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        void EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/HelloWorld", ReplyAction="http://tempuri.org/IWSMessage/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/HelloWorld", ReplyAction="http://tempuri.org/IWSMessage/HelloWorldResponse")]
        System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState);
        
        string EndHelloWorld(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/GetListMyMessages", ReplyAction="http://tempuri.org/IWSMessage/GetListMyMessagesResponse")]
        M2LinkXamarin.WebServiceClients.Message[] GetListMyMessages(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/GetListMyMessages", ReplyAction="http://tempuri.org/IWSMessage/GetListMyMessagesResponse")]
        System.IAsyncResult BeginGetListMyMessages(System.Guid id, System.AsyncCallback callback, object asyncState);
        
        M2LinkXamarin.WebServiceClients.Message[] EndGetListMyMessages(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/AddMessage", ReplyAction="http://tempuri.org/IWSMessage/AddMessageResponse")]
        void AddMessage(System.Guid ownerId, string message, string pseudo);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/AddMessage", ReplyAction="http://tempuri.org/IWSMessage/AddMessageResponse")]
        System.IAsyncResult BeginAddMessage(System.Guid ownerId, string message, string pseudo, System.AsyncCallback callback, object asyncState);
        
        void EndAddMessage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/GetListMessagesFollow", ReplyAction="http://tempuri.org/IWSMessage/GetListMessagesFollowResponse")]
        M2LinkXamarin.WebServiceClients.Message[] GetListMessagesFollow(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/GetListMessagesFollow", ReplyAction="http://tempuri.org/IWSMessage/GetListMessagesFollowResponse")]
        System.IAsyncResult BeginGetListMessagesFollow(System.Guid id, System.AsyncCallback callback, object asyncState);
        
        M2LinkXamarin.WebServiceClients.Message[] EndGetListMessagesFollow(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/GetNbFollow", ReplyAction="http://tempuri.org/IWSMessage/GetNbFollowResponse")]
        int GetNbFollow(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/GetNbFollow", ReplyAction="http://tempuri.org/IWSMessage/GetNbFollowResponse")]
        System.IAsyncResult BeginGetNbFollow(System.Guid id, System.AsyncCallback callback, object asyncState);
        
        int EndGetNbFollow(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/IsFollow", ReplyAction="http://tempuri.org/IWSMessage/IsFollowResponse")]
        bool IsFollow(System.Guid myId, System.Guid hisId);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/IsFollow", ReplyAction="http://tempuri.org/IWSMessage/IsFollowResponse")]
        System.IAsyncResult BeginIsFollow(System.Guid myId, System.Guid hisId, System.AsyncCallback callback, object asyncState);
        
        bool EndIsFollow(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/Follow", ReplyAction="http://tempuri.org/IWSMessage/FollowResponse")]
        void Follow(System.Guid myId, System.Guid hisId);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/Follow", ReplyAction="http://tempuri.org/IWSMessage/FollowResponse")]
        System.IAsyncResult BeginFollow(System.Guid myId, System.Guid hisId, System.AsyncCallback callback, object asyncState);
        
        void EndFollow(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/UnFollow", ReplyAction="http://tempuri.org/IWSMessage/UnFollowResponse")]
        void UnFollow(System.Guid myId, System.Guid hisId);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSMessage/UnFollow", ReplyAction="http://tempuri.org/IWSMessage/UnFollowResponse")]
        System.IAsyncResult BeginUnFollow(System.Guid myId, System.Guid hisId, System.AsyncCallback callback, object asyncState);
        
        void EndUnFollow(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSMessageChannel : M2LinkXamarin.WebServiceClients.IWSMessage, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSMessageClient : System.ServiceModel.ClientBase<M2LinkXamarin.WebServiceClients.IWSMessage>, M2LinkXamarin.WebServiceClients.IWSMessage
    {
        
        public WSMessageClient()
        {
        }
        
        public WSMessageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public WSMessageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public WSMessageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public WSMessageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void DoWork()
        {
            base.Channel.DoWork();
        }
        
        public System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        public void EndDoWork(System.IAsyncResult result)
        {
            base.Channel.EndDoWork(result);
        }
        
        public string HelloWorld()
        {
            return base.Channel.HelloWorld();
        }
        
        public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginHelloWorld(callback, asyncState);
        }
        
        public string EndHelloWorld(System.IAsyncResult result)
        {
            return base.Channel.EndHelloWorld(result);
        }
        
        public M2LinkXamarin.WebServiceClients.Message[] GetListMyMessages(System.Guid id)
        {
            return base.Channel.GetListMyMessages(id);
        }
        
        public System.IAsyncResult BeginGetListMyMessages(System.Guid id, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetListMyMessages(id, callback, asyncState);
        }
        
        public M2LinkXamarin.WebServiceClients.Message[] EndGetListMyMessages(System.IAsyncResult result)
        {
            return base.Channel.EndGetListMyMessages(result);
        }
        
        public void AddMessage(System.Guid ownerId, string message, string pseudo)
        {
            base.Channel.AddMessage(ownerId, message, pseudo);
        }
        
        public System.IAsyncResult BeginAddMessage(System.Guid ownerId, string message, string pseudo, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginAddMessage(ownerId, message, pseudo, callback, asyncState);
        }
        
        public void EndAddMessage(System.IAsyncResult result)
        {
            base.Channel.EndAddMessage(result);
        }
        
        public M2LinkXamarin.WebServiceClients.Message[] GetListMessagesFollow(System.Guid id)
        {
            return base.Channel.GetListMessagesFollow(id);
        }
        
        public System.IAsyncResult BeginGetListMessagesFollow(System.Guid id, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetListMessagesFollow(id, callback, asyncState);
        }
        
        public M2LinkXamarin.WebServiceClients.Message[] EndGetListMessagesFollow(System.IAsyncResult result)
        {
            return base.Channel.EndGetListMessagesFollow(result);
        }
        
        public int GetNbFollow(System.Guid id)
        {
            return base.Channel.GetNbFollow(id);
        }
        
        public System.IAsyncResult BeginGetNbFollow(System.Guid id, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetNbFollow(id, callback, asyncState);
        }
        
        public int EndGetNbFollow(System.IAsyncResult result)
        {
            return base.Channel.EndGetNbFollow(result);
        }
        
        public bool IsFollow(System.Guid myId, System.Guid hisId)
        {
            return base.Channel.IsFollow(myId, hisId);
        }
        
        public System.IAsyncResult BeginIsFollow(System.Guid myId, System.Guid hisId, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginIsFollow(myId, hisId, callback, asyncState);
        }
        
        public bool EndIsFollow(System.IAsyncResult result)
        {
            return base.Channel.EndIsFollow(result);
        }
        
        public void Follow(System.Guid myId, System.Guid hisId)
        {
            base.Channel.Follow(myId, hisId);
        }
        
        public System.IAsyncResult BeginFollow(System.Guid myId, System.Guid hisId, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginFollow(myId, hisId, callback, asyncState);
        }
        
        public void EndFollow(System.IAsyncResult result)
        {
            base.Channel.EndFollow(result);
        }
        
        public void UnFollow(System.Guid myId, System.Guid hisId)
        {
            base.Channel.UnFollow(myId, hisId);
        }
        
        public System.IAsyncResult BeginUnFollow(System.Guid myId, System.Guid hisId, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginUnFollow(myId, hisId, callback, asyncState);
        }
        
        public void EndUnFollow(System.IAsyncResult result)
        {
            base.Channel.EndUnFollow(result);
        }
    }
}