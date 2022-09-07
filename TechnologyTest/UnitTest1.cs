using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Technology;

namespace TechnologyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncreasingRam()
        {
            Computer testingComputer = new Computer(2, 3, true);
            Assert.AreEqual(2, testingComputer.Ram);
            testingComputer.IncreaseRam(3);
            Assert.AreEqual(5, testingComputer.Ram);
        }

        [TestMethod]
        public void TestTakingSelfies()
        {
            SmartPhone testingSmartphone = new SmartPhone(2, 3, true, 800);
            testingSmartphone.TakeSelfie();
            Assert.AreEqual(801, testingSmartphone.SelfieNumber);
        }
    }
}