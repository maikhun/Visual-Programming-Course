using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Rectangle : Parallelogram
    {
        public Rectangle() { name = "Rectangle"; }
        public Rectangle(double a, double b, string color) : this()
        {
            if (a > 0 && b > 0)
            {
                this.a = a;
                this.b = b;
            }
            this.color = color;
        }

        public override double Area
        {
            get { return a * b; }
        }
    }
}
