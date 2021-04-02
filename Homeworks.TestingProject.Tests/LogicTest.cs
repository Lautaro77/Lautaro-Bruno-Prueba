using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homeworks.TestingProject.Tests
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void SumIsOk()
        {
            int sum = 2 + 2;
            Assert.AreEqual(4, sum);
        }

        [TestMethod]
        public void SumIsNotReallyOk()
        {
            int sum = 2 + 3;
            Assert.AreEqual(6, sum);
        }
    }
}