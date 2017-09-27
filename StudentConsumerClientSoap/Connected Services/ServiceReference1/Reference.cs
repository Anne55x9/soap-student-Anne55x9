﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentConsumerClientSoap.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/StudentWcfService")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IStudent")]
    public interface IStudent {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddStudent", ReplyAction="http://tempuri.org/IStudent/AddStudentResponse")]
        void AddStudent(StudentConsumerClientSoap.ServiceReference1.Student s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddStudent", ReplyAction="http://tempuri.org/IStudent/AddStudentResponse")]
        System.Threading.Tasks.Task AddStudentAsync(StudentConsumerClientSoap.ServiceReference1.Student s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/FindStudent", ReplyAction="http://tempuri.org/IStudent/FindStudentResponse")]
        StudentConsumerClientSoap.ServiceReference1.Student FindStudent(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/FindStudent", ReplyAction="http://tempuri.org/IStudent/FindStudentResponse")]
        System.Threading.Tasks.Task<StudentConsumerClientSoap.ServiceReference1.Student> FindStudentAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteStudent", ReplyAction="http://tempuri.org/IStudent/DeleteStudentResponse")]
        void DeleteStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteStudent", ReplyAction="http://tempuri.org/IStudent/DeleteStudentResponse")]
        System.Threading.Tasks.Task DeleteStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/EditStudent", ReplyAction="http://tempuri.org/IStudent/EditStudentResponse")]
        void EditStudent(StudentConsumerClientSoap.ServiceReference1.Student s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/EditStudent", ReplyAction="http://tempuri.org/IStudent/EditStudentResponse")]
        System.Threading.Tasks.Task EditStudentAsync(StudentConsumerClientSoap.ServiceReference1.Student s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetAllStudents", ReplyAction="http://tempuri.org/IStudent/GetAllStudentsResponse")]
        StudentConsumerClientSoap.ServiceReference1.Student[] GetAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetAllStudents", ReplyAction="http://tempuri.org/IStudent/GetAllStudentsResponse")]
        System.Threading.Tasks.Task<StudentConsumerClientSoap.ServiceReference1.Student[]> GetAllStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentChannel : StudentConsumerClientSoap.ServiceReference1.IStudent, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentClient : System.ServiceModel.ClientBase<StudentConsumerClientSoap.ServiceReference1.IStudent>, StudentConsumerClientSoap.ServiceReference1.IStudent {
        
        public StudentClient() {
        }
        
        public StudentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddStudent(StudentConsumerClientSoap.ServiceReference1.Student s) {
            base.Channel.AddStudent(s);
        }
        
        public System.Threading.Tasks.Task AddStudentAsync(StudentConsumerClientSoap.ServiceReference1.Student s) {
            return base.Channel.AddStudentAsync(s);
        }
        
        public StudentConsumerClientSoap.ServiceReference1.Student FindStudent(string name) {
            return base.Channel.FindStudent(name);
        }
        
        public System.Threading.Tasks.Task<StudentConsumerClientSoap.ServiceReference1.Student> FindStudentAsync(string name) {
            return base.Channel.FindStudentAsync(name);
        }
        
        public void DeleteStudent(int id) {
            base.Channel.DeleteStudent(id);
        }
        
        public System.Threading.Tasks.Task DeleteStudentAsync(int id) {
            return base.Channel.DeleteStudentAsync(id);
        }
        
        public void EditStudent(StudentConsumerClientSoap.ServiceReference1.Student s) {
            base.Channel.EditStudent(s);
        }
        
        public System.Threading.Tasks.Task EditStudentAsync(StudentConsumerClientSoap.ServiceReference1.Student s) {
            return base.Channel.EditStudentAsync(s);
        }
        
        public StudentConsumerClientSoap.ServiceReference1.Student[] GetAllStudents() {
            return base.Channel.GetAllStudents();
        }
        
        public System.Threading.Tasks.Task<StudentConsumerClientSoap.ServiceReference1.Student[]> GetAllStudentsAsync() {
            return base.Channel.GetAllStudentsAsync();
        }
    }
}