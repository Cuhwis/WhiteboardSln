using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumOccurencesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, NumOccurences.Program.NumOccur("ladedahdedah", 'd'));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, NumOccurences.Program.NumOccur("Oorah Marine Corps", 'o'));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(3, NumOccurences.Program.NumOccur("!@#@$^%$&@$~@#$%@@$!~#", '#'));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, NumOccurences.Program.NumOccur("", 'n'));
        }

    }
}
