using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
  //  internal class Cylinder
    
        public class Cylinder : Cone
        {
            public Cylinder(double radius, double heigth, double length)
                : base(length, heigth)
            {
                this.radius = radius;
                this.heigth = heigth;
                this.length = length;
            }


            public override double Volume()
            {
                return base.Area() * length;
            }
            public override double Area()
            {
                double area = 2 * base.Area() + 2 * Math.Round(Math.PI, 2) * radius * length;
                return area;
            }
        }
}
