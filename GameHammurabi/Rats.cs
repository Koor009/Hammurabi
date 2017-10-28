using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Rats
    {

        Random rand = new Random();
        public ManageTheState manage;
        public Rats(ManageTheState manage)
        {
            this.manage = manage;
        }
        /// <summary>
        /// Method RatsEat describes how many mice stole corn in year 
        /// </summary>
        public void RatsEat()
        {
            int EatRats = rand.Next(0, 251); //from 0 to 250
            if (EatRats <=manage.Corn)//the amount of food should not exceed the current
            {
                Console.WriteLine($"Mice ate {EatRats}");
                manage.Corn -= EatRats;
                Console.WriteLine($"Balance {manage.Corn}");
            }

        }
    }
}
