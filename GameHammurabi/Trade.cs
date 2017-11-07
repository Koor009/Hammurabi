using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Trade
    {

        Manage manage;
        Sell sell;
        public Trade(Manage manage, Sell sell)
        {
            this.manage = manage;
            this.sell = sell;
        }
        /// <summary>
        /// Method Trading desсribe trade for buy/sell land, currency corn
        /// </summary>
        public void TradingBay(int trade)
        {
            int buy = trade * sell.Price;// exchange rate(corn), said land size
            if (buy <= manage.Corn)//if size sell corn doesn`t exceed the current
            {
                if (manage.Land >= trade)// if amount acr land doesn`t exceed for sell 
                {
                    manage.Land = manage.Land + trade;
                    Console.WriteLine($"Amount acr land {manage.Land}");
                }
                trade *= sell.Price;//exchange corn
                Console.WriteLine($"Trade, buy/sell corn: {trade}");
                if (manage.Corn >= trade)//if ammount corn doesn`t exceed sell 
                {
                    manage.Corn = manage.Corn - trade;
                    Console.WriteLine($"Balance corn {manage.Corn}");
                }
                else
                {
                    Console.WriteLine("not enought corn");
                    Console.WriteLine($"Balance corn {manage.Corn}");
                }
            }
            else
            {
                Console.WriteLine("Not enought corn");
                Console.WriteLine($"Balance corn {manage.Corn}");
            }
        }
        public void TradingSell(int trade)
        {
            int buy = trade * sell.Price;// exchange rate(corn), said land size
            if (buy <= manage.Corn)//if size sell corn doesn`t exceed the current
            {
                if (manage.Land >= trade)// if amount acr land doesn`t exceed for sell 
                {
                    manage.Land = manage.Land + trade;
                    Console.WriteLine($"Amount acr land {manage.Land}");
                }
                trade *= sell.Price;//exchange corn
                Console.WriteLine($"Trade, buy/sell corn: {trade}");
                if (manage.Corn >= trade)//if ammount corn doesn`t exceed sell 
                {
                    manage.Corn = manage.Corn - trade;
                    Console.WriteLine($"Balance corn {manage.Corn}");
                }
                else
                {
                    Console.WriteLine("not enought corn");
                    Console.WriteLine($"Balance corn {manage.Corn}");
                }
            }
            else
            {
                Console.WriteLine("Not enought corn");
                Console.WriteLine($"Balance corn {manage.Corn}");
            }
        }
    }
}
