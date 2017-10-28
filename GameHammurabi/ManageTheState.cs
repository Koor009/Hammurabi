using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class ManageTheState
    {

        public int People { get; set; }
        public int Land { get; set; }
        public int Corn { get; set; }
        /// <summary>
        /// In the ManageTheState constructor, settilng first value parameters
        /// amount corn, land area, people
        /// </summary>
        public ManageTheState(int Corn, int Land, int People)
        {
            this.Corn = Corn;
            this.Land = Land;
            this.People = People;

        }
    }
}
