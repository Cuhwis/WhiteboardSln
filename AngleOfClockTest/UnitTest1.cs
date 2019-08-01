using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngleOfClock;

namespace AngleOfClockTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(90, Program.angleDiff(3, 0));
        }
    }
}
