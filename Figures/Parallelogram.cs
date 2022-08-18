using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Parallelogram : Figure
    {
        protected double a;
        protected double b;
        protected double ha;

        public double A { get { return a; } private set { a = value; } }
        public double B { get { return b; } private set { b = value; } }
        public double Ha { get { return ha; } private set { ha = value; } }

        public Parallelogram() { name = "Parallelogram"; }
        public Parallelogram(double a, double b, double ha, string color) : this()
        {
            if (a > 0 && b > 0 && ha > 0)
            {
                this.a = a;
                this.b = b;
                this.ha = ha;
            }   
            this.color = color;
            
        }
        public override double Perimeter
        {
            get { return 2 * (a + b); }
        }
        public override double Area
        {
            get { return ha * a; }
        }
    }
}
