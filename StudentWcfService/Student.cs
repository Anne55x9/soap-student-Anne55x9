using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentWcfService
{
    /// <summary>
    /// Klassen student med DataMembers som er systemets properties Name og Id. 
    /// </summary>
    [DataContract]
    public class Student
    {
        /// <summary>
        /// DataMember Name i klassen student.
        /// </summary>
        [DataMember]

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Datamember Id  i klassen student.
        /// </summary>

        [DataMember]

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Tostring metoden i klassen student. 
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return "Navn:" + Name + "Id" + Id;
        }

    }
}