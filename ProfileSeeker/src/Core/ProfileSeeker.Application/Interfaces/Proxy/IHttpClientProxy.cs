using System.Net.Http;

namespace ProfileSeeker.Application
{
    public interface IHttpClientProxy
    {
        HttpClient GetHttpClient(string apiUrl);
    }
}
