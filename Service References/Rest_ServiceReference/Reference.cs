﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestService_Test.Rest_ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/RestService_Wcf")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="groupdt", Namespace="http://schemas.datacontract.org/2004/07/RestService_Wcf")]
    [System.SerializableAttribute()]
    public partial class groupdt : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccessFnmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GrpIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VerNoField;
        
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
        public string AccessFnm {
            get {
                return this.AccessFnmField;
            }
            set {
                if ((object.ReferenceEquals(this.AccessFnmField, value) != true)) {
                    this.AccessFnmField = value;
                    this.RaisePropertyChanged("AccessFnm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GrpId {
            get {
                return this.GrpIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GrpIdField, value) != true)) {
                    this.GrpIdField = value;
                    this.RaisePropertyChanged("GrpId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VerNo {
            get {
                return this.VerNoField;
            }
            set {
                if ((object.ReferenceEquals(this.VerNoField, value) != true)) {
                    this.VerNoField = value;
                    this.RaisePropertyChanged("VerNo");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccessFileNames", Namespace="http://schemas.datacontract.org/2004/07/RestService_Wcf")]
    [System.SerializableAttribute()]
    public partial class AccessFileNames : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccessFileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VersionNoField;
        
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
        public string AccessFile {
            get {
                return this.AccessFileField;
            }
            set {
                if ((object.ReferenceEquals(this.AccessFileField, value) != true)) {
                    this.AccessFileField = value;
                    this.RaisePropertyChanged("AccessFile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GroupId {
            get {
                return this.GroupIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupIdField, value) != true)) {
                    this.GroupIdField = value;
                    this.RaisePropertyChanged("GroupId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VersionNo {
            get {
                return this.VersionNoField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionNoField, value) != true)) {
                    this.VersionNoField = value;
                    this.RaisePropertyChanged("VersionNo");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Rest_ServiceReference.IRest_Service1")]
    public interface IRest_Service1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRest_Service1/GetData", ReplyAction="http://tempuri.org/IRest_Service1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRest_Service1/GetData", ReplyAction="http://tempuri.org/IRest_Service1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRest_Service1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IRest_Service1/GetDataUsingDataContractResponse")]
        RestService_Test.Rest_ServiceReference.CompositeType GetDataUsingDataContract(RestService_Test.Rest_ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRest_Service1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IRest_Service1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<RestService_Test.Rest_ServiceReference.CompositeType> GetDataUsingDataContractAsync(RestService_Test.Rest_ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRest_Service1/GetGroupData", ReplyAction="http://tempuri.org/IRest_Service1/GetGroupDataResponse")]
        RestService_Test.Rest_ServiceReference.groupdt GetGroupData(string pgroupid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRest_Service1/GetGroupData", ReplyAction="http://tempuri.org/IRest_Service1/GetGroupDataResponse")]
        System.Threading.Tasks.Task<RestService_Test.Rest_ServiceReference.groupdt> GetGroupDataAsync(string pgroupid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRest_Service1/InsertAccessFileName", ReplyAction="http://tempuri.org/IRest_Service1/InsertAccessFileNameResponse")]
        string InsertAccessFileName(RestService_Test.Rest_ServiceReference.AccessFileNames AccessFileInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRest_Service1/InsertAccessFileName", ReplyAction="http://tempuri.org/IRest_Service1/InsertAccessFileNameResponse")]
        System.Threading.Tasks.Task<string> InsertAccessFileNameAsync(RestService_Test.Rest_ServiceReference.AccessFileNames AccessFileInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRest_Service1Channel : RestService_Test.Rest_ServiceReference.IRest_Service1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Rest_Service1Client : System.ServiceModel.ClientBase<RestService_Test.Rest_ServiceReference.IRest_Service1>, RestService_Test.Rest_ServiceReference.IRest_Service1 {
        
        public Rest_Service1Client() {
        }
        
        public Rest_Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Rest_Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Rest_Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Rest_Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public RestService_Test.Rest_ServiceReference.CompositeType GetDataUsingDataContract(RestService_Test.Rest_ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<RestService_Test.Rest_ServiceReference.CompositeType> GetDataUsingDataContractAsync(RestService_Test.Rest_ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public RestService_Test.Rest_ServiceReference.groupdt GetGroupData(string pgroupid) {
            return base.Channel.GetGroupData(pgroupid);
        }
        
        public System.Threading.Tasks.Task<RestService_Test.Rest_ServiceReference.groupdt> GetGroupDataAsync(string pgroupid) {
            return base.Channel.GetGroupDataAsync(pgroupid);
        }
        
        public string InsertAccessFileName(RestService_Test.Rest_ServiceReference.AccessFileNames AccessFileInfo) {
            return base.Channel.InsertAccessFileName(AccessFileInfo);
        }
        
        public System.Threading.Tasks.Task<string> InsertAccessFileNameAsync(RestService_Test.Rest_ServiceReference.AccessFileNames AccessFileInfo) {
            return base.Channel.InsertAccessFileNameAsync(AccessFileInfo);
        }
    }
}
