using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.Domain;
using Homeworks.DataAccess;
using Moq;

namespace Homeworks.BusinessLogic.Tests
{
    [TestClass]
    public class AdministratorLogicTests
    {
        [TestMethod]
        public void CreateValidAdministratorOKTest() 
        {
            Administrator administrador = new Administrator();
            administrador.Name = "Jorge";
            administrador.Email = "juan@gmail.com";
            administrador.Password = "letmein1";

            var mock = new Mock<IAdministratorRepository>(MockBehavior.Strict);//mockeo la interfaz, SIMULO LA INTERFAZ, voy a estar 
            mock.Setup(m => m.Add(It.IsAny<Administrator>()));
            mock.Setup(m => m.Save());

            var administratorLogic = new AdministratorLogic(mock.Object);//le estoy pasando un mock de la interfaz, o interfaz mockeada, ESTAMOS PASANDO OTRA IMPLEMENTACION, JUSTO ES UN MOCK
            Administrator result = administratorLogic.Create(administrador);



            mock.VerifyAll();
            Assert.AreEqual(administrador.Name, result.Name);



        }
    }
}
