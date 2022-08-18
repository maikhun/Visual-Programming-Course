using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Square : NGon
    {
        public Square() { name = "Square"; }
        public Square(int cornerNumber, double side, string color) : this()
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
            get { return side * 4; }
        }
        public override double Area
        {
            get { return side * side; }
        }
    }
}
