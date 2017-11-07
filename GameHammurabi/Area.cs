using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Area
    {
        internal float Ration{ get; set; }
        internal Manage manage;
        public Area(Manage manage)
        {
            this.manage = manage;
        }
        public float Sation()
        {
            Ration =(float)(manage.Land / manage.People);
            return Ration;
        }
    }
}
