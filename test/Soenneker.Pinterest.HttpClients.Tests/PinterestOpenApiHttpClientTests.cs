using Soenneker.Pinterest.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Pinterest.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PinterestOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IPinterestOpenApiHttpClient _httpclient;

    public PinterestOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IPinterestOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
