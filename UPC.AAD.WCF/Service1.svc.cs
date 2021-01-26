using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UPC.AAD.BE;
using UPC.AAD.BL;

namespace UPC.AAD.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly StudentBL objStudentBL;

        public Service1()
        {
            objStudentBL = new StudentBL();
        }

        public IEnumerable<Student.ShortInformation> ListarTodos()
        {
            var students = objStudentBL.ListarTodos();
            var response = from student in students
                           select new Student.ShortInformation()
                           {
                               IdStudent = student.IdStudent,
                               Name = student.Name,
                               LastName = student.LastName
                           };

            return response;
        }

        public int Registrar(Student.FullInformation objStudent)
        {
            var request = new StudentBE.FullInformation() { 
                Name = objStudent.Name,
                LastName = objStudent.LastName,
                BirthDate = objStudent.BirthDate,
                Email = objStudent.Email,
                Ponderado = objStudent.Ponderado
            };
            var id = objStudentBL.Registrar(request);

            return id;
        }
    }
}
