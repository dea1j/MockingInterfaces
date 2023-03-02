using System;
using System.Net.Http;

namespace Implementation
{
    public interface IHttpHandler
    {
        HttpResponseMessage Send(string content, string url);
    }
}