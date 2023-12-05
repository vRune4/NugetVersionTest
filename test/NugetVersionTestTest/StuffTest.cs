using NugetVersionTest;
using Xunit;

namespace NugetVersionTestTest;

public class StuffTest
{
    [Fact]
    public void TestMeaningOfLifeReturns42()
    {
        var stuff = new Stuff();
        Assert.Equal(42, stuff.MeaningOfLife);
    }

    [Fact]
    public void TestSomeOtherThingReturnsSix()
    {
        var stuff = new Stuff();
        Assert.Equal(6, stuff.SomeOtherThing);
    }
}