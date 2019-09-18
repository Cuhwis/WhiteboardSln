using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace subStringMatchTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void findSubString1()
        {
            Assert.AreEqual(-1, subStringMatch.Program.findSubString("",""));
        }
        [TestMethod]
        public void findSubString2()
        {
            Assert.AreEqual(8, subStringMatch.Program.findSubString("catinthehat", "hat"));
        }
        [TestMethod]
        public void findSubString3()
        {
            Assert.AreEqual(1, subStringMatch.Program.findSubString("mississippi", "is"));
        }
        [TestMethod]
        public void findSubString4()
        {
            Assert.AreEqual(-1, subStringMatch.Program.findSubString("function", "dog"));
        }
        [TestMethod]
        public void findSubString5()
        {
            Assert.AreEqual(-1, subStringMatch.Program.findSubString("healthy", ""));
        }
    }
}
