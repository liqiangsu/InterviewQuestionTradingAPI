using Microsoft.Extensions.Logging;
using MockTradingApi;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestionTradingAPI.Services
{
    public class SymbolService
    {
        private readonly ILogger<SymbolService> _logger;
        private readonly ITradingApi _tradingApi;

        public SymbolService(ILogger<SymbolService> logger, ITradingApi tradingApi)
        {
            _logger = logger;
            _tradingApi = tradingApi;
        }

        public IEnumerable<Symbol> GetAllSymbols()
        {
            return _tradingApi.GetSymbols();
        }

    }
}
