using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation;

namespace OceanNavigation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string sno;
            int option = 0;
            while(true)
            {
                option = ShipUI.Menu();
                if(option==1)
                {
                    ship s = ShipUI.GetInputfromConsole();
                    shipDL.AddShip(s);
                }
                else if(option==2)
                {
                    sno = ShipUI.GetserialNoforDisplayLocation();
                   ship.ViewLocation(sno);
                }
                else if (option == 3)
                {
                    ShipUI.ViewSerialNo();
                }
                else if (option == 4)
                {
                    sno = ShipUI.GetserialNoforChangeLocation();
                    ShipUI.changelocation(sno);
                }
                else if (option == 5)
                {
                    break;
                }
                ShipUI.clear();
            }
        }
        
        }
       }
    
        
     
    

