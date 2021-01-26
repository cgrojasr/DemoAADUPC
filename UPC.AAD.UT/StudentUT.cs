using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using UPC.AAD.BE;
using UPC.AAD.BL;

namespace UPC.AAD.UT
{
    [TestClass]
    public class StudentUT
    {
        StudentBL objStudentBL;

        public StudentUT()
        {
            objStudentBL = new StudentBL();
        }

        [TestMethod]
        public void ListarTodos()
        {
            var todos = objStudentBL.ListarTodos();
            Assert.AreEqual(todos.Count(), 1);
        }

        [TestMethod]
        public void Registrar()
        {
            StudentBE.FullInformation objStudentBE = new StudentBE.FullInformation();
            objStudentBE.Name = "Christian";
            objStudentBE.LastName = "Rojas";
            objStudentBE.BirthDate = DateTime.Parse("1986-10-12");
            objStudentBE.Email = "pciscroj@upc.edu.pe";
            objStudentBE.Ponderado = 15;
            var id = objStudentBL.Registrar(objStudentBE);

            Assert.AreEqual(id, 2);
        }
    }
}
