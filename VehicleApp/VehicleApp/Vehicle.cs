using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle
    {
        public string VehicleName {private get; set; }
        public string Regno { private get; set; }

        private List<double> speed = new List<double>();
        private double max;

        public void Speed(double newSpeed)
        {
            speed.Add(newSpeed);
        }

        public Vehicle(string vehicle, string regno):this()
        {
            VehicleName = vehicle;
            Regno = regno;
        }
        public Vehicle()
        {
            max= 0;
        }

        public string ShowMaxSpeed()
        {

            foreach (double maxspeed in speed)
            {
                if (max < maxspeed)
                {
                    max = maxspeed;
                }
            }
          return max.ToString();
        }

        public string ShowMinSpeed()
        {
            speed.Sort();
            return speed[0].ToString();
        }

        public string ShowAverageSpeed()
        {
            double total = 0;
            int count = 0;
            foreach (double allSpeed in speed)
            {
                count++;
                total += allSpeed;
            }
            return (total/count).ToString();
        }
    }
}
