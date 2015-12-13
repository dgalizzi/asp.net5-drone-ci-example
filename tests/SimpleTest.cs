using Xunit;

namespace Tests
{
    public class SimpleTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(2*2, 4);
            Assert.Equal(3*3, 10);
        }

    }
}
