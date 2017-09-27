using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWcfService.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void AddStudentTest()
        {
            //Arrange

            Student st = new Student();


            //Act
            st.Id = 3;
            st.Name = "Karl";
            int idtest = st.Id;
            string nametest = st.Name;

            //Assert
            Assert.AreEqual(3, idtest);
            Assert.AreEqual("Karl", nametest);


        }

        [TestMethod()]
        public void GetAllStudentsTest()
        {
            //Arrange

            Service1 ser = new Service1();

            //Act
            Student s = new Student
            {
                Id = 3,
                Name = "Flemse"
            };
            ser.AddStudent(s);

            List<Student> listtest = ser.GetAllStudents();



            //Assert

            Assert.AreEqual("Flemse", listtest.Find(p => p.Name == s.Name).Name);
        }

        [TestMethod()]
        public void FindStudentTest()
        {
            //Arrange
            Service1 st = new Service1();

            //Act
            Student name = st.FindStudent("kasper");

            //Assert
            Assert.AreEqual("kasper", name.Name);

        }

    }
}