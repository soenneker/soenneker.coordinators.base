using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Coordinators.Base.Tests;

[Collection("Collection")]
public class BaseCoordinatorTests : FixturedUnitTest
{
    public BaseCoordinatorTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
