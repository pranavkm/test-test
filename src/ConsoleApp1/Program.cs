

using NUnit.Framework;

namespace ConsoleApp1
{
    [TestFixture]
    public class Program
    {
        [Test]
        public void SimpleTest()
        {
            var value = "Hello";

            var value2 = "Hello";

            Assert.AreEqual(value, value2);
        }

        [Test]
        public void SimpleTest2()
        {
            var value = "Hello";

            var value2 = "Hello";

            Assert.AreEqual(value, value2);
        }
    }
}
