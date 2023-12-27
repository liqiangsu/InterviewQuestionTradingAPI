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


        //TODO
        //3.	GET /api/price/{symbol}
        //•	Return the latest Price of a { symbol }
        [HttpGet("{symbol}")]
        public Price GetPrice(string symbol)
        {
            throw new NotImplementedException();
        }


        //TODO
        //4.	Get /api/price/{symbol}/history
        //•	Return the PriceStats that contains Open, Close, Min and Max, for the current Minute, for a given symbol. (hint) An extension method could help you with the time
        [HttpGet("{symbol}/history")]
        public PriceStats GetPriceStats(string symbol)
        {
            throw new NotImplementedException();
        }

    }
}
