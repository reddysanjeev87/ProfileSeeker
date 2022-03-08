using ProfileSeeker.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProfileSeeker.Persisstence.Github.Proxy
{
    /// <summary>
    /// this is the proxy class for HttpClient
    /// Interface is explicitly implemented sothat 
    /// class members are private
    /// </summary>
    public class HttpClientProxy : IHttpClientProxy
    {
        HttpClient IHttpClientProxy.GetHttpClient(string apiUrl)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(apiUrl);
            httpClient.DefaultRequestHeaders.Add("User-Agent", "request");
            return httpClient;
        }
    }
}
