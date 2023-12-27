using MockTradingApi;
using System.Collections.Generic;

namespace InterviewQuestionTradingAPI.Services
{
    public class SymbolService
    {
        private readonly ITradingApi _tradingApi;

        public SymbolService(ITradingApi tradingApi)
        {
            _tradingApi = tradingApi;
        }
        public IEnumerable<Symbol> GetSymbols()
        {
            return _tradingApi.GetSymbols();
        }
    }
}
