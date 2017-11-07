using System;

namespace GameHammurabi
{
    class Program
    {
        static void Main(string[] args)
        {

            int Year = 0;

            Manage manage = new Manage(3000,1000,100);
            Sell sell = new Sell();
            Trade baySell = new Trade(manage,sell);
            Ate foodpeople = new Ate(manage);
            Plant growing = new Plant(manage);
            Mortality mortality = new Mortality(foodpeople);
            Rats rats = new Rats(manage);
            Area area = new Area(manage);
            Conclusion conclusion = new Conclusion(area);
            // Rats rats = new Rats(manage);
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
                    baySell.TradingBay(acr);
                    Console.WriteLine($"Select the amount of corn  per person, need 20 per one..., now people {manage.People}");
                    int corn = int.Parse(Console.ReadLine());
                    foodpeople.FeedPeople(corn);
                    Console.WriteLine($"How much will you grow corn {manage.Corn}, now lend {manage.Land}");
                    int grow = int.Parse(Console.ReadLine());
                    growing.Growing(grow);
                    rats.RatsEat();
                    if (i == 10)
                    {
                        Console.WriteLine("You win");
                        Console.WriteLine(mortality.Amount());
                        Console.WriteLine(area.Sation());
                        conclusion.OutputLend();
                        conclusion.OutputManagement();
                        break;
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
