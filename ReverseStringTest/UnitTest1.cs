using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("rats", Program.reverseStringUno("star"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("987654", Program.reverseStringUno("456789"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("gaws", Program.reverseStringUno("swag"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("sirhc@", Program.reverseStringUno("@chris"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("#C", Program.reverseStringUno("C#"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("rats", Program.reverseStringUno("star"));
        }

    }
}
