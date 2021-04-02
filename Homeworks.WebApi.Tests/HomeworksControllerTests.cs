using Homeworks.BusinessLogic;
using Homeworks.Domain;
using Homeworks.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.WebApi.Tests
{
    [TestClass]
    public class HomeworksControllerTests
    {
        [TestMethod]
        public void CreateValidHomeworkOkTest()
        {
          /*  Homework homework = new Homework();
            homework.DueDate = DateTime.Now;
            homework.Description = "testing description";

            var mock = new Mock<IHomeworkLogic>(MockBehavior.Strict);
            mock.Setup(m => m.Create(It.IsAny<Homework>())).Returns(homework); // Hola
            var controller = new HomeworksController(mock.Object);

            var result = controller.Post(homework);
            var createdResult = result as CreatedAtRouteResult;
            var model = createdResult.Value as Homework;

            mock.VerifyAll();
            Assert.AreEqual(homework.Description, model.Description);
            Assert.AreEqual(homework.DueDate, model.DueDate);*/
        }
    }
}
