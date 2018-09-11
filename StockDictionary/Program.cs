using System;
using System.Collections.Generic;

namespace StockDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("IBM", "IBM");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 42.24));
            purchases.Add((ticker: "CAT", shares: 300, price: 56.14));
            purchases.Add((ticker: "AAPL", shares: 600, price: 942.15));
            purchases.Add((ticker: "IBM", shares: 500, price: 900.42));
        }
    }
}
