using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Ring : Circle
    {
        public double secondRadius;
        public Ring() { name = "Ring"; }
        public Ring(double radius, double secondRadius, string color) : this()
        {
            if (secondRadius > 0)
                this.secondRadius = secondRadius;
            this.color = color;
            if (radius > 0)
                this.radius = radius;
        }
        public override double Area
        {
            get { return base.Area - (Math.PI * Math.Pow(secondRadius, 2)); }
        }
    }
}
