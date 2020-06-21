﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="MyService", ConfigurationName="ServiceReference1.ICheckinService", CallbackContract=typeof(Client.ServiceReference1.ICheckinServiceCallback))]
    public interface ICheckinService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="MyService/ICheckinService/Checkin")]
        void Checkin(string userName, int roomnum);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="MyService/ICheckinService/Checkin")]
        System.Threading.Tasks.Task CheckinAsync(string userName, int roomnum);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICheckinServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="MyService/ICheckinService/ShowInk")]
        void ShowInk(string ink);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="MyService/ICheckinService/ShowLogin")]
        void ShowLogin(string loginUserName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="MyService/ICheckinService/ShowLogout")]
        void ShowLogout(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="MyService/ICheckinService/ShowTalk")]
        void ShowTalk(string userName, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICheckinServiceChannel : Client.ServiceReference1.ICheckinService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CheckinServiceClient : System.ServiceModel.DuplexClientBase<Client.ServiceReference1.ICheckinService>, Client.ServiceReference1.ICheckinService {
        
        public CheckinServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CheckinServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CheckinServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CheckinServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CheckinServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Checkin(string userName, int roomnum) {
            base.Channel.Checkin(userName, roomnum);
        }
        
        public System.Threading.Tasks.Task CheckinAsync(string userName, int roomnum) {
            return base.Channel.CheckinAsync(userName, roomnum);
        }
    }
}