using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class GrowingFood
    {

        public ManageTheState manage;

        public GrowingFood(ManageTheState manage)
        {
            this.manage = manage;
        }
        /// <summary>
        /// Growing describes how we can grow corn, 1 acr land = 1 corn
        /// </summary>
        public void Growing(int corn)
        {
            if (corn <= manage.Land)//amount corn must not wos more than  lands 
            {
                manage.Corn += corn;
            }
            else
            {
                Console.WriteLine("Not enought land");
            }

        }
    }
}
