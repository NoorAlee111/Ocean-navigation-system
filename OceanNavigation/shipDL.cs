using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation;

namespace OceanNavigation
{
    class shipDL
    {
        public static List<ship> ships = new List<ship>();
        public static void AddShip(ship s)
        {
            ships.Add(s);
        }
    }
}
