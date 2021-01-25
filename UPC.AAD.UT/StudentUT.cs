using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
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
    }
}
