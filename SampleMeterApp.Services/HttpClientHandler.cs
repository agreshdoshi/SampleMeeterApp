using SampleMeterApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SampleMeterApp.Services
{
    public class HttpClientHandler : HttpClient, IHttpClientHandler
    {

        public async Task<string> GetStringAsync()
        {
            var builder = new UriBuilder("https://ermapi.azurewebsites.net/api/meter");
            var query = HttpUtility.ParseQueryString(builder.Query);
            return await base.GetStringAsync(new Uri(builder.ToString()));
        }
    }
}
