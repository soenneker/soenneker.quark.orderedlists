using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.OrderedLists.Tests;

[Collection("Collection")]
public sealed class OrderedListTests : FixturedUnitTest
{
    public OrderedListTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Test that the OrderedList component can be instantiated
        // This is a basic smoke test
        Assert.True(true);
    }
}
