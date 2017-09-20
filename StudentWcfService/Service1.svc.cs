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
    public class Service1 : IService1
    {
        /// <summary>
        /// En poperty af typen student.
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// Deklarationen af en listen af typen student som er statisk. 
        /// </summary>

        public static List<Student> studentlist = new List<Student>();

        /// <summary>
        /// private variable idIndex til at automatiske tilføje næste id i systemet. Sat til 1 første gang den bruges.
        /// </summary>
        private int idIndex = 1;

        /// <summary>
        /// Klassens konstruktør med 3 suderende som er tilføjet med name. Id er autogeneret. 
        /// </summary>

        public Service1()
        {
            AddStudent(new Student { Name = "Kasper" });
            AddStudent(new Student { Name = "Ditte" });
            AddStudent(new Student { Name = "Søren" });
            

        }

        /// <summary>
        /// Metode med loakl parameter student af typen Student til at tilføje en studerende i listen.
        /// I metoden bruges klassen private variable idIndex med tælle operatoren ++. 
        /// Operatoren lægger 1 til for hver stident objekt kald.
        /// Objektet student må ikke være null. 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>

        public Student AddStudent(Student student)
        {
            if(student == null)
            {
                throw new ArgumentNullException("student");
            }
            student.Id = idIndex++;
            studentlist.Add(student);
            return student;
        }

        /// <summary>
        /// Metode til at finde en studerende udfra navn. 
        /// Funktionen Find bruges på listen med lambda expression til søgning på navn.
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Student FindStudent(string name)
        {
            return studentlist.Find(p => p.Name == name);
        }

        /// <summary>
        /// Metode til at fjerne en studerende fra listen.
        /// Funktionen RemoveAll bruges på listen med lambda expression som fjerner udfra student Id. 
        /// </summary>
        /// <param name="id"></param>

        public void RemoveStudent(string name)
        {
            studentlist.RemoveAll(p => p.Name == name);
        }


        /// <summary>
        /// Metode til at ændre og/eller opdatere en studerende i listen. 
        /// Elemnt må ikke være null.
        /// metoden indeholder en lokal variable index. Variablen er givent fundet ID i listen.
        /// Metoden FindIndex på listen med lambda expression identificere og bruges til først at 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public Student EditStudent(Student student)
        {
            return student;
        
        }

        /// <summary>
        /// Metode til at hente alle studerende på listen.
        /// Metoden er af typen IEnumrable som er et interface 
        /// med en metode som tillader iterativt gennemgang af collections vha property.
        /// </summary>
        /// <returns></returns>
        public List<Student> GetAll()
        {
           
            return studentlist;
        }


    }
}
