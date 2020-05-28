using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HebCalReactDemo.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HebCalReactDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiDemoController : ControllerBase
    {
        [Route("test")]
        public HebCalConversionResult Test()
        {
            return HebCalApi.ConvertToHebrew(new DateTime(1982, 1, 31));
        }

        [Route("shabbos")]
        [HttpGet]
        public ShabbosTimesResult GetShabbosTime(string zip)
        {
            return HebCalApi.GetUpcomingShabbosTimes(zip);
        }
    }
}