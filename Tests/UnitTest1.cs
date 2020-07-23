using CsvHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.IO;

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

        class Datarow
        {
            readonly string a;
            readonly string b;
            readonly string c;
        }

        [TestMethod]
        public void TestMethod2()
        {
            string data = 
@"a,b,c
1,2,3
4,5,6";
            var apiCsv = new CsvReader(new StringReader(data), CultureInfo.InvariantCulture).GetRecords<Datarow>();

            Assert.IsTrue(true, "this one passes");
        }
    }
}
