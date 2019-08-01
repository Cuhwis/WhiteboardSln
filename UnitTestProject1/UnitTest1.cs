using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngleOfClock;

namespace AngleOfClock
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AngleDiffTest0300()
        {
            Assert.AreEqual(90, AngleOfClock.angleOfClock(3, 0));
        }
        [TestMethod]
        public void AngleDiffTest0930()
        {
            Assert.AreEqual(90, AngleOfClock.angleOfClock(3, 0));
        }
        [TestMethod]
        public void AngleDiffTest1200()
        {
            Assert.AreEqual(0, AngleOfClock.angleOfClock(3, 0));
        }
        [TestMethod]
        public void AngleDiffTest0430()
        {
            Assert.AreEqual(60, AngleOfClock.angleOfClock(3, 0));
        }
    }
}
