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
            st.Id = 2;
            st.Name = "Karl";
            int idtest = st.Id;
            string nametest = st.Name;

            //Assert
            Assert.AreEqual(2, idtest);
            Assert.AreEqual("Karl",nametest);
           
            
        }

     
    }
}