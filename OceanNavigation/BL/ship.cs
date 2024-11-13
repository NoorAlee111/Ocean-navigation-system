using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation;

namespace OceanNavigation.BL
{
    class ship
    {
        public string ShipNumber;
        public angle latitude = new angle();
        public angle longitude = new angle();
        public ship(string ShipNumber,angle latitude,angle longitude)
        {
            this.ShipNumber = ShipNumber;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        
        public void DisplayShipSerialno()
        {
            Console.WriteLine("Ship's serial number is {0}", ShipNumber);
        }
        public void DisplayLocation()
        {

            angleUI.DisplayyShipPosition(longitude, latitude);
        }
        public static void ViewLocation(string sno)
        {

            for (int i = 0; i < shipDL.ships.Count; i++)
            {
                if (sno == shipDL.ships[i].ShipNumber)
                {
                    shipDL.ships[i].DisplayLocation();
                }
            }
        }
    }
}
