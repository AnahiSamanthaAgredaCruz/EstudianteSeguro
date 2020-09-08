using System;
using System.Collections.Generic;
using System.Net.Http;
using ApiSeccureStudent.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtEstudianteSeguro.TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arange
            StudentsController studentsController = new StudentsController();


            //Act

            var ListaEstudiantes = studentsController.GetStudents();


            //Assert
            Assert.IsNotNull(ListaEstudiantes);
        }
    }
} 
