using Newtonsoft.Json;
using SampleMeterApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleMeterApp.Services
{
    public class MeterService :IMeterService
    {
        private IHttpClientHandler httpClientHandler;

        public MeterService(IHttpClientHandler httpClientHandler)
        {
            this.httpClientHandler = httpClientHandler;
        }


        public async Task<IEnumerable<Meter>> GetMetersAsync()

        {
            var json = String.Empty;
            List<Meter> items;
            try
            {
                json = await httpClientHandler.GetStringAsync();
                if (String.IsNullOrEmpty(json)) throw new Exception();
                items = JsonConvert.DeserializeObject<List<Meter>>(json);
                if (items.Count == 0) throw new Exception();
            }
            catch (Exception)
            {
                throw new Exception("Cannot retrieve data from the server");
            }
           
            return items;
        }
    }
}
