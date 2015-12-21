using Xunit;

namespace MyFirstDnxUnitTests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
            Assert.Equal(6, Add(3, 3));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
