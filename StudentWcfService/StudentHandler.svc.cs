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
        static List<Student> studentList = new List<Student>()
        {
            new Student(){Id = 1, Name = "Anne"},
            new Student(){Id = 2, Name = "kasper"}
        };

     
        /// <summary>
        /// Metode som tilføjer en ny studerende til listen. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public void AddStudent(Student s)
        {
           
            studentList.Add(s);
            
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
        public List<Student> GetAllStudents()
        {
         
                return studentList;
    
        }

        /// <summary>
        /// Metode som fjerner en studerende fra listen ved brug af deres navn. 
        /// </summary>
        /// <param name="name"></param>

        public void DeleteStudent(int id)
        {
            studentList.RemoveAll(p => p.Id == id);
        }

        public void EditStudent(Student s)
        {
            var student = studentList.Find(p => p.Id == s.Id);
            student.Id = s.Id;
            student.Name = s.Name;

        }


       
    }
}
