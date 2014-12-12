﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAPP
{
    class Circle
    {
        private double radius;
        public double Radius { private get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetDiameter()
        {
            return 2 * Radius;
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
