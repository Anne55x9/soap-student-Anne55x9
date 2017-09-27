using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentWcfService
{
    /// <summary>
    /// Infaset IStudent med operationcontracts med datatype eller void metode signatur. 
    /// </summary>
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudent
    {
        /// <summary>
        /// Addstudent metoden med lokale s af typen student
        /// </summary>
       

        [OperationContract]
        void AddStudent(Student s);

        /// <summary>
        /// FindStudent udfra navn.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        [OperationContract]
        Student FindStudent(string name);

        /// <summary>
        /// RemoveStudent studerende fjernes fra listen udfra id. 
        /// </summary>
        /// <param name="id"></param>
        [OperationContract]
        void DeleteStudent(int id);


        [OperationContract]
        void EditStudent(Student s);

        /// <summary>
        /// GetAll studerende på en liste. 
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Student> GetAllStudents();

    }

    //Udkommenteret kode fra wcf filen. 

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
