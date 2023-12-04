using NugetVersionTest;
using Xunit;

namespace NugetVersionTestTest
{
    public class StuffTest
    {
        [Fact]
        public void TestMeaningOfLife()
        {
            var stuff = new Stuff();
            Assert.Equal(42, stuff.MeaningOfLife);
        }
    }
}