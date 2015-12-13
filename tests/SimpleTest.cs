using Xunit;

namespace Tests
{
    public class SimpleTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(2*2, 4);
            Assert.Equal(3*3, 9);
        }

        [Fact]
        public void TestSum()
        {
            Assert.Equal(2+2, 4);
            Assert.Equal(3+3, 6);
            Assert.Equal(1+1, 2);
        }

    }
}
