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
        /// Addstudent metoden med lokale parametre id og navn.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [OperationContract]
        Student AddStudent(int id, string name);

        /// <summary>
        /// FindStudent udfra navn.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        [OperationContract]
        Student FindStudent(string name);

        /// <summary>
        /// GetAll studerende på en liste. 
        /// </summary>
        /// <returns></returns>

        [OperationContract]
        List<Student> GetAll();

        /// <summary>
        /// RemoveStudent studerende fjernes fra listen udfra navn. 
        /// </summary>
        /// <param name="name"></param>
        [OperationContract]
        void RemoveStudent(string name);

        //[OperationContract]
        //Student EditStudent(int id, string name);


        //Udkommenterede metoder i wcf filen. 

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
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
