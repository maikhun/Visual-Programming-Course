using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Rhomb : Parallelogram
    {
        public Rhomb() { name = "Rhomb"; }
        public Rhomb(double side, double height, string color) : this()
        {
            if (side > 0 && height > 0)
            {
                this.a = side;
                this.b = side;
                this.ha = height;
            }
            this.color = color;
        }
        public double LengthSide
        {
            set
            {
                a = value;
                b = value;
            }
            get
            {
                return a;
            }
        }

    }
}
