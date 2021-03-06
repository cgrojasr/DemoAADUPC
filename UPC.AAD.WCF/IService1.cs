﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UPC.AAD.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Student.ShortInformation> ListarTodos();
        [OperationContract]
        int Registrar(Student.FullInformation objStudent);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
    public class Student {
        [DataContract]
        public class ShortInformation
        {
            [DataMember]
            public int IdStudent { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string LastName { get; set; }
            [DataMember]
            public bool Active { get; set; }
        }

        [DataContract]
        public class FullInformation
        {
            [DataMember]
            public int IdStudent { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string LastName { get; set; }
            [DataMember]
            public DateTime BirthDate { get; set; }
            [DataMember]
            public string Email { get; set; }
            [DataMember]
            public decimal Ponderado { get; set; }
            [DataMember]
            public string Picture { get; set; }
            public bool Active { get; set; }
        }
    }
}
