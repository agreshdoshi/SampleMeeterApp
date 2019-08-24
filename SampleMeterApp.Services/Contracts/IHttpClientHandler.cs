using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleMeterApp.Services.Contracts
{
    public interface IHttpClientHandler
    {
        Task<string> GetStringAsync();
    }
}
