using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   // internal class Cone
    
        public class Cone : Solid_figures
        {
            protected double radius;

            public Cone(double a, double b)
                : base(a, b)
            {
                this.radius = a;
                this.heigth = b;
            }



            public override double Area()
            {
                double area = Math.Round((Math.PI), 2) * radius * radius;
                return area;
            }

            public override double Volume()
            {
                double volume = (Math.Round((Math.PI), 2) * radius * radius * heigth) / 3;
                return volume;
            }
        }
}
