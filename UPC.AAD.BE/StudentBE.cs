using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.AAD.BE
{
    public class StudentBE
    {
        public class FullInformation {
            public int IdStudent { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Email { get; set; }
            public float Ponderado { get; set; }
            public string Picture { get; set; }
            public bool Active { get; set; }
        }

        public class ShortInformation {
            public int IdStudent { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public bool Active { get; set; }
        }
    }
}
