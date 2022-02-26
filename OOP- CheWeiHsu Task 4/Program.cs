using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__CheWeiHsu_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool still = false;
            do
            {
                Double r1;
                Console.WriteLine("Here we can calculate circle's basic values. Values will be rounded to third decimal place.");
                Console.Write("Give circle's radius: ");
                String r = Console.ReadLine();
                while (!Double.TryParse(r, out r1) || r1< 0)
                {
                    Console.Write("Invalid, try again: ");
                    r = Console.ReadLine();
                }


                Circle circle1 = new Circle(r1);
                circle1.GetArea();
                circle1.GetDiameter();
                circle1.GetCircumference();
                Console.WriteLine();
                Console.Write("Do you want to continue?(Y/N): ");
                string answer = Console.ReadLine().ToUpper();
                while (answer != "Y" && answer != "N")
                {
                    Console.Write("Please answer Y or N: ");
                    answer = Console.ReadLine().ToUpper();
                }

                if (answer == "Y")
                {
                    still = true;
                }
                else
                {
                    still = false;
                }


            } while (still);

        }
    }
}
