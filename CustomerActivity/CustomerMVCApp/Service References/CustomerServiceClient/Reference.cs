﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerMVCApp.CustomerServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/CustomerDomainModel")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PostalCodeField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDNumber {
            get {
                return this.IDNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.IDNumberField, value) != true)) {
                    this.IDNumberField = value;
                    this.RaisePropertyChanged("IDNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> PostalCode {
            get {
                return this.PostalCodeField;
            }
            set {
                if ((this.PostalCodeField.Equals(value) != true)) {
                    this.PostalCodeField = value;
                    this.RaisePropertyChanged("PostalCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultModelError", Namespace="http://schemas.datacontract.org/2004/07/CustomerServiceLayer")]
    [System.SerializableAttribute()]
    public partial class FaultModelError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyNameField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyName {
            get {
                return this.PropertyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyNameField, value) != true)) {
                    this.PropertyNameField = value;
                    this.RaisePropertyChanged("PropertyName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerServiceClient.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetAll", ReplyAction="http://tempuri.org/ICustomerService/GetAllResponse")]
        CustomerMVCApp.CustomerServiceClient.Customer[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetAll", ReplyAction="http://tempuri.org/ICustomerService/GetAllResponse")]
        System.Threading.Tasks.Task<CustomerMVCApp.CustomerServiceClient.Customer[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCountOfRecords", ReplyAction="http://tempuri.org/ICustomerService/GetCountOfRecordsResponse")]
        int GetCountOfRecords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCountOfRecords", ReplyAction="http://tempuri.org/ICustomerService/GetCountOfRecordsResponse")]
        System.Threading.Tasks.Task<int> GetCountOfRecordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomersPaged", ReplyAction="http://tempuri.org/ICustomerService/GetCustomersPagedResponse")]
        CustomerMVCApp.CustomerServiceClient.Customer[] GetCustomersPaged(int pageNumber, int recordCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomersPaged", ReplyAction="http://tempuri.org/ICustomerService/GetCustomersPagedResponse")]
        System.Threading.Tasks.Task<CustomerMVCApp.CustomerServiceClient.Customer[]> GetCustomersPagedAsync(int pageNumber, int recordCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomerByID", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerByIDResponse")]
        CustomerMVCApp.CustomerServiceClient.Customer GetCustomerByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomerByID", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerByIDResponse")]
        System.Threading.Tasks.Task<CustomerMVCApp.CustomerServiceClient.Customer> GetCustomerByIDAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomerByName", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerByNameResponse")]
        CustomerMVCApp.CustomerServiceClient.Customer GetCustomerByName(string customerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomerByName", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerByNameResponse")]
        System.Threading.Tasks.Task<CustomerMVCApp.CustomerServiceClient.Customer> GetCustomerByNameAsync(string customerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CustomerMVCApp.CustomerServiceClient.FaultModelError[]), Action="http://tempuri.org/ICustomerService/AddCustomerArrayOfFaultModelErrorFault", Name="ArrayOfFaultModelError", Namespace="http://schemas.datacontract.org/2004/07/CustomerServiceLayer")]
        void AddCustomer(CustomerMVCApp.CustomerServiceClient.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(CustomerMVCApp.CustomerServiceClient.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CustomerMVCApp.CustomerServiceClient.FaultModelError[]), Action="http://tempuri.org/ICustomerService/UpdateCustomerArrayOfFaultModelErrorFault", Name="ArrayOfFaultModelError", Namespace="http://schemas.datacontract.org/2004/07/CustomerServiceLayer")]
        void UpdateCustomer(CustomerMVCApp.CustomerServiceClient.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task UpdateCustomerAsync(CustomerMVCApp.CustomerServiceClient.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(CustomerMVCApp.CustomerServiceClient.FaultModelError[]), Action="http://tempuri.org/ICustomerService/DeleteCustomerArrayOfFaultModelErrorFault", Name="ArrayOfFaultModelError", Namespace="http://schemas.datacontract.org/2004/07/CustomerServiceLayer")]
        void DeleteCustomer(CustomerMVCApp.CustomerServiceClient.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(CustomerMVCApp.CustomerServiceClient.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : CustomerMVCApp.CustomerServiceClient.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<CustomerMVCApp.CustomerServiceClient.ICustomerService>, CustomerMVCApp.CustomerServiceClient.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CustomerMVCApp.CustomerServiceClient.Customer[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<CustomerMVCApp.CustomerServiceClient.Customer[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public int GetCountOfRecords() {
            return base.Channel.GetCountOfRecords();
        }
        
        public System.Threading.Tasks.Task<int> GetCountOfRecordsAsync() {
            return base.Channel.GetCountOfRecordsAsync();
        }
        
        public CustomerMVCApp.CustomerServiceClient.Customer[] GetCustomersPaged(int pageNumber, int recordCount) {
            return base.Channel.GetCustomersPaged(pageNumber, recordCount);
        }
        
        public System.Threading.Tasks.Task<CustomerMVCApp.CustomerServiceClient.Customer[]> GetCustomersPagedAsync(int pageNumber, int recordCount) {
            return base.Channel.GetCustomersPagedAsync(pageNumber, recordCount);
        }
        
        public CustomerMVCApp.CustomerServiceClient.Customer GetCustomerByID(int ID) {
            return base.Channel.GetCustomerByID(ID);
        }
        
        public System.Threading.Tasks.Task<CustomerMVCApp.CustomerServiceClient.Customer> GetCustomerByIDAsync(int ID) {
            return base.Channel.GetCustomerByIDAsync(ID);
        }
        
        public CustomerMVCApp.CustomerServiceClient.Customer GetCustomerByName(string customerName) {
            return base.Channel.GetCustomerByName(customerName);
        }
        
        public System.Threading.Tasks.Task<CustomerMVCApp.CustomerServiceClient.Customer> GetCustomerByNameAsync(string customerName) {
            return base.Channel.GetCustomerByNameAsync(customerName);
        }
        
        public void AddCustomer(CustomerMVCApp.CustomerServiceClient.Customer customer) {
            base.Channel.AddCustomer(customer);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(CustomerMVCApp.CustomerServiceClient.Customer customer) {
            return base.Channel.AddCustomerAsync(customer);
        }
        
        public void UpdateCustomer(CustomerMVCApp.CustomerServiceClient.Customer customer) {
            base.Channel.UpdateCustomer(customer);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerAsync(CustomerMVCApp.CustomerServiceClient.Customer customer) {
            return base.Channel.UpdateCustomerAsync(customer);
        }
        
        public void DeleteCustomer(CustomerMVCApp.CustomerServiceClient.Customer customer) {
            base.Channel.DeleteCustomer(customer);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(CustomerMVCApp.CustomerServiceClient.Customer customer) {
            return base.Channel.DeleteCustomerAsync(customer);
        }
    }
}
