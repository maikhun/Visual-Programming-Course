using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Figure
    {
        protected string name = String.Empty;
        protected string color = String.Empty;

        public string Name { get { return name; } set { name = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Figure()
        {
            this.color = "None";
            this.name = "None";
        }
        public virtual double Perimeter
        {
            get { return 0;  }
        }
        public virtual double Area
        {
            get { return 0; }
        }
        public override string ToString()
        { 
            return $"Фигура: {name}, Цвет: {color}, Периметр: {this.Perimeter}, Площадь: {this.Area}";
        }
    }
}

