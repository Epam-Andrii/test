using ConsoleApplication.Services;
using NUnit.Framework;

namespace ConsoleApplication.UnitTests
{
    [TestFixture]
    public class FormaterTests
    {
        [Test]
        public void TestMethod1()
        {
            var formater = new Formater();
            var name = "Test";
            var val = formater.SayHello(name);
            Assert.AreEqual("Hello " + name, val);
        }
    }
}
