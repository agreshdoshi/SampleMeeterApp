using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleMeterApp.Services.Contracts;

namespace SampleMeterApp.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private IMeterService meterService;
        public SampleDataController(IMeterService meterService)
        {
            this.meterService = meterService;
        }
        [HttpGet("[action]")]
        public async Task<IEnumerable<Meter>> Products()
        {
            return await this.meterService.GetMetersAsync();
        }
        

    }
}
