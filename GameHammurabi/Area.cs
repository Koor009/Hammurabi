using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Area
    {
        public float Ration{ get; set; }
        public Manage manage;
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
