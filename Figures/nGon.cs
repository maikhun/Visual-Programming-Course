using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class NGon : Figure
    {
        protected int cornerNumber;
        protected double side;

        public int CornerNumber { get { return cornerNumber; } private set { cornerNumber = value; } }
        public double Side { get { return side; } private set { side = value; } }

        public NGon() { name = "n-gon"; }
        public NGon(int cornerNumber, double side, string color) : this()
        {
            if (cornerNumber > 0 && side > 0)
            {
                this.cornerNumber = cornerNumber;
                this.side = side;
            }
            this.color = color;
        }
        public override double Perimeter
        {
            get { return side * cornerNumber; }
        }
        public override double Area
        {
            get { return (Math.Pow(side, 2) * cornerNumber) / (4 * Math.Tan(Math.PI / cornerNumber)); }
        }

    }
}
