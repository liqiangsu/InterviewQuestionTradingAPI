using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewQuestionTradingAPI.Services;
using MockTradingApi;

namespace InterviewQuestionTradingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SymbolsController : ControllerBase
    {
        private readonly ILogger<SymbolsController> _logger;
        private readonly PriceServices _services;

        public SymbolsController(ILogger<SymbolsController> logger, PriceServices services)
        {
            _logger = logger;
            _services = services;
        }


        //TODO
        //1.	GET /api/symbols
        //•	Return a list of all symbols
        [HttpGet]
        public IEnumerable<Symbol> Get()
        {
            throw new NotImplementedException();
        }


        //TODO
        //2.	GET /api/symbols/{name}
        //•	Return a single Symbol object with the {name }





    }
}
