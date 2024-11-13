using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation;

namespace OceanNavigation.BL
{
    class angle
    {
      public  int degrees;
        public float minutes;
        public char ShipDirection;
        public angle(int degrees,float minutes,char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.ShipDirection = direction;
        }
        public angle()
        {
            degrees = 0;
            minutes = 0.0F;
            ShipDirection = ' ';
        }
       
       
      
    }
}
