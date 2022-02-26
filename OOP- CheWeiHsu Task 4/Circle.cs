using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__CheWeiHsu_Task_4
{
    class Circle
    {
        public Circle(double aRadius)
        {  
            Radius = aRadius;
        }

        public double Radius { get; set; }


        public void GetArea()
        {
            double pi = Math.PI;

            double Area = Radius * Radius * pi;
            double Area2 = Math.Round(Area, 3);
            Console.WriteLine($"This circle's area is {Area2}");
        }

        public void GetDiameter()
        {
            double D = Radius * 2;
            double D2 = Math.Round(D, 3);
            Console.WriteLine($"This circle's diameter is {D2}");
        }
        public void GetCircumference()
        {
            double pi = Math.PI;
            double C = Radius * pi;
            double C2 = Math.Round(C, 3);
            Console.WriteLine($"This circle's Circumference is {C2}");
        }
    }


}

