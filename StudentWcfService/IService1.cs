using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// Funktion som tilføjer en studerende.
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>

        [OperationContract]
        Student AddStudent(Student student);

        /// <summary>
        /// Funktion som finder studerende ud fra navn.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [OperationContract]
        Student FindStudent(string name);

        /// <summary>
        /// Funktion som kan slette en studerende fra listen.
        /// </summary>
        /// <param name="id"></param>

        [OperationContract]
        void RemoveStudent(string name);

        /// <summary>
        /// Funktion som kan refigere/opdatere en studerende.
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>

        [OperationContract]
        Student EditStudent(Student student);

        /// <summary>
        /// Metoden GetAll som er en IEnumarable collection af typen studerende med alle de studerende.
        /// </summary>
        /// <returns></returns>

        List<Student> GetAll();
  

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    //// Use a data contract as illustrated in the sample below to add composite types to service operations.
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
