using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true, "this one passes");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("this one fails");
        }
    }
}
