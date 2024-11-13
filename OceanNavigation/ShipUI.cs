using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation;

namespace OceanNavigation
{
    class ShipUI
    {
        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("*****************************************************");
            Console.WriteLine("******************OCEAN NAVIGATION*******************");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("1:Add Ship");
            Console.WriteLine("2:View Ship Position");
            Console.WriteLine("3:View Ship Serial Number");
            Console.WriteLine("4:Change Ship Position");
            Console.WriteLine("5:Exit");
            Console.WriteLine("Enter your option:");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void clear()
        {
            Console.WriteLine("Enter any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static ship GetInputfromConsole()
        {
            string serialno = "";
            angle latitude = new angle();
            angle longitude = new angle();
            Console.WriteLine("Enter Ship number:");
            serialno = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude:");
            Console.WriteLine("Enter Latitude's Degree:");
            latitude.degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Minute:");
            latitude.minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Direction:");
            latitude.ShipDirection = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude:");
            Console.WriteLine("Enter Longitude's Degree:");
            longitude.degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Minute:");
            longitude.minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Direction:");
            longitude.ShipDirection = char.Parse(Console.ReadLine());
            ship s = new ship(serialno, latitude, longitude);
            return s;
        }
        public static void changelocation(string sno)
        {
            for (int i = 0; i < shipDL.ships.Count; i++)
            {
                if (sno == shipDL.ships[i].ShipNumber)
                {
                    angle a = new angle();
                    angle longitude = new angle();
                    angle latitude = new angle();
                    Console.WriteLine("Enter Ship Latitude:");
                    Console.WriteLine("Enter Latitude's Degree:");
                    latitude.degrees = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Minute:");
                    latitude.minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Direction:");
                    latitude.ShipDirection = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Ship Longitude:");
                    Console.WriteLine("Enter Longitude's Degree:");
                    longitude.degrees = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Minute:");
                    longitude.minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Direction:");
                    longitude.ShipDirection = char.Parse(Console.ReadLine());
                    shipDL.ships[i].longitude = longitude;
                    shipDL.ships[i].latitude = latitude;
                }
            }
        }
        public static string GetserialNoforDisplayLocation()
        {
            string sno = "";
            Console.WriteLine("Enter ship serial number to find it's position..");
            sno = Console.ReadLine();
            return sno;
        }
        public static string GetserialNoforChangeLocation()
        {
            string sno = "";
            Console.WriteLine("Enter ship serial number whose position you want to change..");
            sno = Console.ReadLine();
            return sno;
        }
      public  static void ViewSerialNo()
        {
            int degreecount = 0;
            int minutecount = 0;
            int directioncount = 0;
            int count = 0;
            angle latitude = new angle();
            angle longitude = new angle();
            string latitude1 = "";
            string longitude1 = "";
            Console.WriteLine("Enter Ship Latitude:");
            latitude1 = Console.ReadLine();
            for (int i = 0; i < latitude1.Length; i++)
            {
                if (latitude1[i] == '*')
                {
                    count++;
                    break;
                }
                degreecount++;
            }

            if (count == 1)
            {
                for (int i = degreecount + 1; i < latitude1.Length; i++)
                {

                    if (latitude1[i] == '\'')
                    {
                        count++;
                    }
                    if (count == 2)
                    {
                        break;
                    }
                    minutecount++;

                }
            }

            for (int i = 0; i < latitude1.Length; i++)
            {
                if (latitude1[i] == 'N' || latitude1[i] == 'E' || latitude1[i] == 'W' || latitude1[i] == 'S')
                {
                    break;
                }
                directioncount++;
            }

            string degrees1 = latitude1.Substring(0, degreecount);
            latitude.degrees = int.Parse(degrees1);

            string minutes1 = latitude1.Substring(degreecount + 1, minutecount);
            latitude.minutes = float.Parse(minutes1);

            string direction1 = latitude1.Substring(directioncount);
            latitude.ShipDirection = char.Parse(direction1);


            Console.WriteLine("Enter Ship Longitude:");
            longitude1 = Console.ReadLine();
            int degreecount1 = 0;
            int minutecount1 = 0;
            int directioncount1 = 0;
            int count1 = 0;
            for (int i = 0; i < longitude1.Length; i++)
            {
                if (longitude1[i] == '*')
                {
                    count1++;
                    break;

                }
                degreecount1++;
            }
            if (count1 == 1)
            {
                for (int i = degreecount1 + 1; i < longitude1.Length; i++)
                {
                    if (longitude1[i] == '\'')
                    {
                        count1++;
                    }
                    if (count1 == 2)
                    {
                        break;
                    }
                    minutecount1++;
                }
            }
            for (int i = 0; i < longitude1.Length; i++)
            {
                if (longitude1[i] == 'N' || longitude1[i] == 'E' || longitude1[i] == 'W' || longitude1[i] == 'S')
                {
                    break;
                }
                directioncount1++;
            }

            string degrees2 = longitude1.Substring(0, degreecount1);
            longitude.degrees = int.Parse(degrees2);
            string minutes2 = longitude1.Substring(degreecount + 1, minutecount1);
            longitude.minutes = float.Parse(minutes2);
            string direction2 = longitude1.Substring(directioncount1);
            longitude.ShipDirection = char.Parse(direction2);


            bool flag = false;
            for (int i = 0; i <= shipDL.ships.Count; i++)

            {

                if (shipDL.ships[i].latitude.degrees == latitude.degrees && shipDL.ships[i].latitude.minutes == latitude.minutes && shipDL.ships[i].latitude.ShipDirection == latitude.ShipDirection)
                {
                    if (shipDL.ships[i].longitude.degrees == longitude.degrees && shipDL.ships[i].longitude.minutes == longitude.minutes && shipDL.ships[i].longitude.ShipDirection == longitude.ShipDirection)
                    {
                        flag = true;
                        shipDL.ships[i].DisplayShipSerialno();
                        break;
                    }
                }
            }
            if (flag == false)
            {
                Console.WriteLine("No ship of this location..");
            }


        }
    }
}
