using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHammurabi
{
    class Mortality
    {
        Ate mans;
        public Mortality(Ate mans)
        {
            this.mans = mans;
        }
        public int Amount()
        {
            return mans.Died;
        }
    }
}
