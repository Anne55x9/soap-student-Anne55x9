using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentWcfService
{
    /// <summary>
    /// Klassen studerende med attributterne Id og navn. 
    /// </summary>
    [DataContract]
    public class Student
    {
        /// <summary>
        /// Datamedlem id i full property.
        /// </summary>
        [DataMember]
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Datamedlem name i full property. 
        /// </summary>
        [DataMember]
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Tostrig af student klasse til Wcf test consol. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Id + Name;
        }

    }
}