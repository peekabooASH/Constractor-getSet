using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultApp
{
    class Result
    {
        //private double physics;
        //private double chemistry;
        //private double math;
        public double Physics{ private get; set ;}
        public double Chemistry { private get; set; }
        public double Math{private get ; set; }

        public Result(double physics, double chemistry, double math)
        {
            Physics = physics;
            Chemistry = chemistry;
            Math = math;
        }

        public double Grade()
        {
            return ((Physics + Chemistry + Math)/3);
        }

        public string GradeLetter()
        {
            if (Grade() >= 80)
            {
                return "A+";
            }
            else if (Grade() >= 70)
            {
                return "B+";
            }
            else if (Grade() >= 60)
            {
                return "C+";
            }
            else if (Grade() >= 50)
            {
                return "D+";
            }
            else 
            {
                return "F";
            }
        }

    }
}
