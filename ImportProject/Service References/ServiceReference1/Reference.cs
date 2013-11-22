﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.261
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImportProject.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LedOutputData", Namespace="http://schemas.datacontract.org/2004/07/LedClientService.Devices")]
    [System.SerializableAttribute()]
    public partial class LedOutputData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ImportProject.ServiceReference1.OutputPriority PriorityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SectionIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int B {
            get {
                return this.BField;
            }
            set {
                if ((this.BField.Equals(value) != true)) {
                    this.BField = value;
                    this.RaisePropertyChanged("B");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int G {
            get {
                return this.GField;
            }
            set {
                if ((this.GField.Equals(value) != true)) {
                    this.GField = value;
                    this.RaisePropertyChanged("G");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ImportProject.ServiceReference1.OutputPriority Priority {
            get {
                return this.PriorityField;
            }
            set {
                if ((this.PriorityField.Equals(value) != true)) {
                    this.PriorityField = value;
                    this.RaisePropertyChanged("Priority");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int R {
            get {
                return this.RField;
            }
            set {
                if ((this.RField.Equals(value) != true)) {
                    this.RField = value;
                    this.RaisePropertyChanged("R");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SectionID {
            get {
                return this.SectionIDField;
            }
            set {
                if ((this.SectionIDField.Equals(value) != true)) {
                    this.SectionIDField = value;
                    this.RaisePropertyChanged("SectionID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int W {
            get {
                return this.WField;
            }
            set {
                if ((this.WField.Equals(value) != true)) {
                    this.WField = value;
                    this.RaisePropertyChanged("W");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OutputPriority", Namespace="http://schemas.datacontract.org/2004/07/LedClientService.Devices")]
    public enum OutputPriority : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Default = -2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scheduled = -1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OneTime = 0,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IControlService", CallbackContract=typeof(ImportProject.ServiceReference1.IControlServiceCallback))]
    public interface IControlService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlService/ImportProject", ReplyAction="http://tempuri.org/IControlService/ImportProjectResponse")]
        void ImportProject(string serverIP, int projectid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlService/ToServerSayHello", ReplyAction="http://tempuri.org/IControlService/ToServerSayHelloResponse")]
        void ToServerSayHello();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlService/Regist", ReplyAction="http://tempuri.org/IControlService/RegistResponse")]
        void Regist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlService/ReloadSchedule", ReplyAction="http://tempuri.org/IControlService/ReloadScheduleResponse")]
        void ReloadSchedule();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlService/GetAllLEDDeviceOutput", ReplyAction="http://tempuri.org/IControlService/GetAllLEDDeviceOutputResponse")]
        ImportProject.ServiceReference1.LedOutputData[] GetAllLEDDeviceOutput();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControlService/ImportDevices", ReplyAction="http://tempuri.org/IControlService/ImportDevicesResponse")]
        void ImportDevices(string serverIP, int projectID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IControlServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IControlService/ToClientSayHello")]
        void ToClientSayHello(string hello);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IControlService/ToClientNotifyLedDisplayChange")]
        void ToClientNotifyLedDisplayChange(int DeviceID, ImportProject.ServiceReference1.LedOutputData outdata);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IControlServiceChannel : ImportProject.ServiceReference1.IControlService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ControlServiceClient : System.ServiceModel.DuplexClientBase<ImportProject.ServiceReference1.IControlService>, ImportProject.ServiceReference1.IControlService {
        
        public ControlServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ControlServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ControlServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ControlServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ControlServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void ImportProject(string serverIP, int projectid) {
            base.Channel.ImportProject(serverIP, projectid);
        }
        
        public void ToServerSayHello() {
            base.Channel.ToServerSayHello();
        }
        
        public void Regist() {
            base.Channel.Regist();
        }
        
        public void ReloadSchedule() {
            base.Channel.ReloadSchedule();
        }
        
        public ImportProject.ServiceReference1.LedOutputData[] GetAllLEDDeviceOutput() {
            return base.Channel.GetAllLEDDeviceOutput();
        }
        
        public void ImportDevices(string serverIP, int projectID) {
            base.Channel.ImportDevices(serverIP, projectID);
        }
    }
}
