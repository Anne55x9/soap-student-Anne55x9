using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace StudentWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    /// <summary>
    /// Klassen Service1 også navngivet StudentHandler i solutionfile menuen. Klassen implementere interfaset IStudent. 
    /// </summary>
    public class Service1 : IStudent
    {
        /// <summary>
        /// Ny instans af listen med studenrende kaldet studenterlist. 
        /// </summary>
        public static List<Student> studentList = new List<Student>();

        /// <summary>
        /// Metode som tilføjer en ny studerende til listen. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Student AddStudent(int id, string name)
        {
            Student tempstudent = new Student();
            tempstudent.Id = id;
            tempstudent.Name = name;
            studentList.Add(tempstudent);
            return tempstudent;
        }

        /// <summary>
        /// Metode som finder studerende udfra deres navn. 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        public Student FindStudent(string name)
        {
            return studentList.Find(p => p.Name == name);
        }

        /// <summary>
        /// Metode som retunere alle elemeneterne på listen studentlist. 
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAll()
        {
            return studentList;
        }

        /// <summary>
        /// Metode som fjerner en studerende fra listen ved brug af deres navn. 
        /// </summary>
        /// <param name="name"></param>

        public void RemoveStudent(string name)
        {
            studentList.RemoveAll(p => p.Name == name);
        }

        //Udkommenterede metoder GetData og GetDataUsing.

        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
