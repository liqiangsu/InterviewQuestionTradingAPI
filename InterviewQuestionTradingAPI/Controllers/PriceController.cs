using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockTradingApi;

namespace InterviewQuestionTradingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriceController : ControllerBase
    {
        [HttpGet("{symbol}")]
        public Price GetPrice(string symbol)
        {
            throw new NotImplementedException();
        }


        [HttpGet("{symbol}/history")]
        public PriceStats GetPriceStats(string symbol)
        {
            throw new NotImplementedException();
        }
    }
}
