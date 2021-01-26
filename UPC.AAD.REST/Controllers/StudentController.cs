using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UPC.AAD.BE;
using UPC.AAD.BL;

namespace UPC.AAD.REST.Controllers
{
    //[RoutePrefix("api/Student")]
    public class StudentController : ApiController
    {
        StudentBL objStudentBL;
        public StudentController()
        {
            objStudentBL = new StudentBL();
        }

        [HttpGet]
        public IEnumerable<StudentBE.ShortInformation> ListarTodos() {
            return objStudentBL.ListarTodos();
        }

        [HttpPost]
        public int Registrar(StudentBE.FullInformation objStudentBE)
        {
            return objStudentBL.Registrar(objStudentBE);
        }

        [HttpPost]
        [Route("Registrar2")]
        public int Registrar2(StudentBE.FullInformation objStudentBE)
        {
            return objStudentBL.Registrar(objStudentBE);
        }
    }
}
