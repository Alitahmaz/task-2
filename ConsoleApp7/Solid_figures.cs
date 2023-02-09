using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
  //  internal class Solid_figures
    
        public abstract class Solid_figures
        {
            protected double length;
            protected double heigth;
            public Solid_figures(double length, double heigth)
            {
            }
            public abstract double Area();
            public abstract double Volume();
        }

    }

