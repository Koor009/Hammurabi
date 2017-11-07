using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Sell
    {
        Random rand = new Random();
        internal int Price { get; set; }
        public void Display()
        {
            Price = rand.Next(17, 27);
            Console.WriteLine($"Price one acr land {Price}");
        }
    }
}
