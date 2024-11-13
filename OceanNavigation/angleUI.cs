using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;

namespace OceanNavigation
{
    class angleUI
    {
        public static void DisplayyShipPosition(angle longitude, angle latitude)
        {
            Console.WriteLine("Ship is at" + longitude.degrees + "\u00b0" + longitude.minutes + "'" + longitude.ShipDirection + " and " + latitude.degrees + "\u00b0" + latitude.minutes + "'" + latitude.ShipDirection);
        }
    }
}
