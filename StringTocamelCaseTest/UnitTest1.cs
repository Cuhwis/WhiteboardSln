using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTocamelCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void toCamel1()
        {
            Assert.AreEqual("catInTheHat", CamelCaseDemo.toCamel("cat In THe hat"));
        }
        [TestMethod]
        public void toCamel2()
        {
            Assert.AreEqual("chrisIsCool", CamelCaseDemo.toCamel("CHRIS IS COOL"));
        }
        [TestMethod]
        public void toCamel3()
        {
            Assert.AreEqual("edSheeranIsASinger", CamelCaseDemo.toCamel("eD sHEEran is a  sINGER"));
        }
        [TestMethod]
        public void toCamelPunctuation()
        {
            Assert.AreEqual("catInTheHat", CamelCaseDemo.toCamel("Cat !!In tHE !@#Ha%%t"));
        }
    }
}
