using Soenneker.Tests.HostedUnit;

namespace Soenneker.Coordinators.Base.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class BaseCoordinatorTests : HostedUnitTest
{
    public BaseCoordinatorTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
