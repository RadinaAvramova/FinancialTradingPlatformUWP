using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketComponent
{
    public class StockMarketData
    {
        public StockMarketData()
        { 
        }

        public async Task<string> GetDataAsync()
        {
            await Task.Delay(5000);

            return "Stockmarket Data";
        }

    }
}
