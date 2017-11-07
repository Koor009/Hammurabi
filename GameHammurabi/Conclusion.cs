using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Conclusion
    {
        public Area area;
        public Conclusion(Area area)
        {
            this.area = area;
        }
        public void OutputLend()
        {
            if (area.Ration >= 10)
            {
                Console.WriteLine($"The amount of land is enough for residents, now for one person{area.Ration} and they feel confortable");
            }
            else if (area.Ration <= 7 && area.Ration > 10)
            {
                Console.WriteLine($"The amount of land is enough for residents, now for one person{area.Ration} and they feel normally");
            }
            else
            {
                Console.WriteLine($"The amount of land isn`t enough for residents, now for one person{area.Ration} and they feel badly");
            }
        }
        public void OutputManagement()
        {
            Console.WriteLine();
        }
    }
}
