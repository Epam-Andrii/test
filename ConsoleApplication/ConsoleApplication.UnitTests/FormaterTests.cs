using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication.Services;

namespace ConsoleApplication.UnitTests
{
    [TestClass]
    public class FormaterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var formater = new Formater();
            var name = "Test";
            var val = formater.SayHello(name);
            Assert.AreEqual("Hello " + name, val);
        }
    }
}
