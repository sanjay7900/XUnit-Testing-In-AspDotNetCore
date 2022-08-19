using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using TestProjectStudents.TestData;
using Xunit;
using XUnitTesting_Implement.Controllers;
using XUnitTesting_Implement.Models;
using XUnitTesting_Implement.Services;

namespace TestProjectStudents
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetAllStudentMethode_GetAll()
        {
            var mockObject = new Mock<IDataServices<Student>>();
            mockObject.Setup(data => data.GetAll()).Returns(StudentDataTested.GetAllDataTest());
            var controller = new StudentsController(mockObject.Object);
            var result = controller.Index();
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Student>>(viewResult.ViewData.Model);
            Assert.Equal(1, model.Count());
        }
    }
}