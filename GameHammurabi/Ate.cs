using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Ate
    {
        internal int Died{ get; set; }
        Random rand = new Random();
        private Manage manage;
        public Ate(Manage manage)
        {
            this.manage = manage;
        }
        /// <summary>
        /// In method FeedPeople pick out size corn for a peoples, if corn not enought, the peoples die
        /// </summary>
        public void FeedPeople(int corn)
        {
            if (manage.Corn >= corn)//if current size corn doesn`t exceed request 
            {
                int Come = rand.Next(0, 11);//the peoples migration in region from 0 to 10 inhabitants 
                int ate = 20;//consumption corn on people
                manage.Corn -= corn;
                Console.WriteLine($"Balance corn {manage.Corn}");
                corn /= ate;//highlight certain size people corn 
                if (manage.People != corn)//if amount people don't coincidence with distinguish for ate  если количество людей не совпадают с выделенными для еды
                {

                    int man = manage.People;
                    man -= corn;
                    Died = man;
                    Console.WriteLine($"Died people from hunger: {man}");
                    manage.People -= man;
                    Console.WriteLine($"Came people {Come}");
                    manage.People += Come;
                    Console.WriteLine($"All people: {manage.People}");
                }
                else
                {
                    Console.WriteLine($"Came people {Come}");
                    manage.People += Come;
                    Console.WriteLine($"All people: {manage.People}");
                }

            }
            else
            {
                Console.WriteLine("Not enought corn");
            }
        }
    }
}
