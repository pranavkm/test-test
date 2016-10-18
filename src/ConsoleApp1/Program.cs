
using Xunit;

namespace ConsoleApp1
{
    public class Program
    {
        [Fact]
        public void SimpleTest()
        {
            var value = "Hello";

            var value2 = "Hello";

            Assert.Equal(value, value2);
        }

        [Fact]
        public void SimpleTest2()
        {
            var value = "Hello";

            var value2 = "Hello";

            Assert.Equal(value, value2);
        }
    }
}
