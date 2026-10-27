using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Pinterest.HttpClients.Abstract;

/// <summary>
/// A thread-safe singleton HTTP client for the Pinterest API.
/// </summary>
public interface IPinterestOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
