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
        private readonly SymbolService _services;

        public SymbolsController(ILogger<SymbolsController> logger, SymbolService services)
        {
            _logger = logger;
            _services = services;
        }

        [HttpGet]
        public IEnumerable<Symbol> Get()
        {
            throw new NotImplementedException();
        }
    }
}
