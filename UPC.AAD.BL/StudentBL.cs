using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.AAD.BE;
using UPC.AAD.DA;

namespace UPC.AAD.BL
{
    public class StudentBL
    {
        StudentDA objStudentDA;

        public StudentBL()
        {
            objStudentDA = new StudentDA();
        }

        public IEnumerable<StudentBE.ShortInformation> ListarTodos() {
            try
            {
                return objStudentDA.ListarTodos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
