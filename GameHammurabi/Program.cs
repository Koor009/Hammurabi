using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammurab
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year = 0;

            ManageTheState manage = new ManageTheState(3000,1000,100);
            Sell sell = new Sell();
            BayingOrSellingLand baySell = new BayingOrSellingLand(manage,sell);
            FoodForPeople foodpeople = new FoodForPeople(manage);
            GrowingFood growing = new GrowingFood(manage);
            Rats rats = new Rats(manage);
            for (int i = 1; i <= 10; i++)
            {
                if (manage.People > 20)
                {
                    Year++;
                    Console.WriteLine($"Year of the Board {Year}");
                    sell.Display();
                    Console.WriteLine($"Сost of a piece of land in this year:{sell.Price}");
                    Console.WriteLine($"how many will you buy or sell lands? Now lands {manage.Land}");
                    int acr = int.Parse(Console.ReadLine());
                    baySell.Trading(acr);
                    Console.WriteLine($"Select the amount of corn  per person, need 20 per one..., now people {manage.People}");
                    int corn = int.Parse(Console.ReadLine());
                    foodpeople.FeedPeople(corn);
                    Console.WriteLine($"How much will you grow corn {manage.Corn}");
                    int grow = int.Parse(Console.ReadLine());
                    growing.Growing(grow);
                    rats.RatsEat();
                    if (i == 10)
                    {
                        Console.WriteLine("You win");
                    }
                }
                else
                {
                    Console.WriteLine("You were overthrown");
                    break;
                }

            }
        }
    }
}
