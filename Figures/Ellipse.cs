using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Ellipse : Circle
    {
        protected double secondRadius;

        public double SecondRadius { get { return secondRadius; } private set { secondRadius = value; } }

        public Ellipse() { name = "Ellipse"; }
        public Ellipse(double radius, double secondRadius, string color) : this()
        {
            this.color = color;
            if (radius > 0)
                this.radius = radius;
            if (secondRadius > 0)
                this.secondRadius = secondRadius;
        }
        public override double Perimeter
        {
            get { return 2 * Math.PI * Math.Sqrt((Math.Pow(radius, 2) + Math.Pow(secondRadius, 2)) / 2); }
        }
        public override double Area
        {
            get { return Math.PI * secondRadius * radius; }
        }
    }
}
