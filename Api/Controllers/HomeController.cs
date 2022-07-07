using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IConvertorService _convertorService;

        public HomeController(IConvertorService convertorService)
        {
            _convertorService = convertorService;
        }

        [HttpPost]
        public IEnumerable<int> Post([FromBody] IEnumerable<char> input)
        {
            return _convertorService.Convert(input);
        }
    }
}
