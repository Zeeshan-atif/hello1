using Microsoft.VisualStudio.TestTools.UnitTesting;
using hello1;

namespace hello11Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = Program.creatMessage();
            string actual = "Hello World";
            Assert.AreEqual(actual, expected);
        }
    }
}
