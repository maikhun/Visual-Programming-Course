using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Circle : Figure
    {
        protected double radius;

        public double Radius { get { return radius; } private set { radius = value; } }
        public Circle() { name = "Circle"; }
        public Circle(double radius, string color) : this()
        {
            this.color = color;
            if (radius > 0)
                this.radius = radius;
        }
        public override double Perimeter
        {
            get { return 2 * Math.PI * radius; }
        }
        public override double Area
        {
            get { return Math.PI * Math.Pow(radius, 2); }
        }
    }
}
