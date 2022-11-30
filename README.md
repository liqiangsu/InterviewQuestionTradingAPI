# Interview
## Welcome
Thanks for cloning this project. This project is mean for conducting a technical interview for C# developers.  
Good luck 🤞 

### How to submit
There are a few ways you can submit your answers:
1. Zip and send the code back to the contacting HR.
2. Just post your forked project link to HR.

## Backgrounds

### Pricing

You are provided a .net standard library that mock a pricing system.
The api simulated getting prices from external services.  
See the diagram below:  
![](diagram1.png)

The library has a class named “TradingApi” which implement interface:
``` c#
public interface ITradingApi
{
    /// <summary>
    /// Get full list of symbol definitions, only two symbols are supported: “AUDUSD” and “CL-OIL”.
    /// </summary>
    /// <returns>Symbols</returns>
    IEnumerable<Symbol> GetSymbols();

    /// <summary>
    /// If there is an in-coming price and the symbol of the price is subscribed by SubscribeSymbol <see cref="SubscribeSymbol"/> an event will fire, the pricing data is passed as event data.
    /// </summary>
    event EventHandler<Price> OnPricing;

    /// <summary>
    /// Subscribe a symbol to receive prices though OnPricing event handler
    /// </summary>
    /// <param name="symbolName">name of a symbol</param>
    void SubscribeSymbol(string symbolName);
}
```
``` c#
public struct Price
{
    public string Symbol { get; }
    public decimal Bid { get; }
    public decimal Ask { get; }
    public DateTime Time { get; }
}

public class Symbol
{
    public string Name { get; set; }
    public string BaseCurrency { get; set; }
    public int Digits { get; set; }
}

public class PriceStats
{
    public decimal Open { get; set; }
    public decimal Close { get; set; }
    public decimal Min { get; set; }
    public decimal Max { get; set; }
}
```

## Tasks
You tasks are to complete these **controllers and services** to full fill the following requirements. The controllers and services are already created created, 

### Symbol API
1.	GET /api/symbols
•	Return a list of all symbols

2.	GET /api/symbols/{name}
•	Return a single Symbol object with the {name}


### Price API
3.	GET /api/price/{symbol}
•	Return the latest Price of a {symbol}

4.	Get /api/price/{symbol}/history
•	Return the PriceStats that contains Open, Close, Min and Max, for the current Minute, for a given symbol. (hint) An extension method could help you with the time  

    a.  Open - The first Bid price in the minute  
    b.	Close – the last Bid price in the minute  
    c.	Min – the lowest Bid price in the minute  
    d.	Max – the highest Bid price in the minute     
