using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.AAD.BE;

namespace UPC.AAD.DA
{
    public class StudentDA
    {
        dbupcaadDataContext dc;
        public StudentDA()
        {
            dc = new dbupcaadDataContext();
        }

        public IEnumerable<StudentBE.ShortInformation> ListarTodos() {
            var query = from student in dc.students
                        select new StudentBE.ShortInformation
                        {
                            IdStudent = student.id,
                            Name = student.name,
                            LastName = student.lastname,
                            Active = student.active
                        };

            return query;
        }

        public int Registrar(StudentBE.FullInformation objStudentBE)
        {
            student request = new student();
            request.name = objStudentBE.Name;
            request.lastname = objStudentBE.LastName;
            request.birthdate = objStudentBE.BirthDate;
            request.email = objStudentBE.Email;
            request.ponderado = objStudentBE.Ponderado;
            request.active = true;
            request.picture = objStudentBE.Picture;
            request.idusercreator = 0;
            request.datecreator = DateTime.Now;

            dc.students.InsertOnSubmit(request);
            dc.SubmitChanges();

            return request.id;
        }
    }
}
