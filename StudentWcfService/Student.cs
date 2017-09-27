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
       [DataMember]
       public int Id { get; set; }

       [DataMember]
       public string Name { get; set; }


    }
}