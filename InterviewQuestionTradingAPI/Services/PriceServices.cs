using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using MockTradingApi;

namespace InterviewQuestionTradingAPI.Services
{
    public class PriceServices
    {
        private readonly ITradingApi _tradingApi;

        public PriceServices(ITradingApi tradingApi)
        {
            _tradingApi = tradingApi;
            _tradingApi.OnPricing += TradingApi_OnPricing;

            //subscribe to all symbols for pricing
            foreach (var symbol in _tradingApi.GetSymbols())
            {
                _tradingApi.SubscribeSymbol(symbol.Name);
            }
        }

        //event callback
        private void TradingApi_OnPricing(object sender, Price e)
        {
            //for each price tick, this method will be invoked
            throw new NotImplementedException();
        }
        private void GetLatestPrice()
        {
            throw new NotImplementedException();
        }

    }
}
