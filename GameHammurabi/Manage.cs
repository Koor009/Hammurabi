using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Manage
    {

        internal int People { get; set; }
        internal int Land { get; set; }
        internal int Corn { get; set; }
        /// <summary>
        /// In the ManageTheState constructor, settilng first value parameters
        /// amount corn, land area, people
        /// </summary>
        public Manage(int Corn, int Land, int People)
        {
            this.Corn = Corn;
            this.Land = Land;
            this.People = People;

        }
    }
}
