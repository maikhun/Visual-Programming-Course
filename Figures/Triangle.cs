using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Triangle :NGon
    {
        public Triangle() { name = "Triangle"; }
        public Triangle(int cornerNumber, double side, string color) : this()
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
            get { return side * 3; }
        }
    public override double Area
        {
            get { return Math.Pow(side, 2) * Math.Sqrt(3) / 4; }
        }
    }
}
