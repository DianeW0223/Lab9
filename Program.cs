using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleTester
{
    class Circle
    {
        
        static void Main(string[] args)
        {
            bool run = true;
            Console.WriteLine("Welcome to the Circle Tester");
            while (run == true)
            {
                Console.WriteLine("Enter radius");
                double input = double.Parse(Console.ReadLine());
                getFormattedCircumference(input);
                getFormattedArea(input);
                run = Continue();
            }

            
        }
        public static double getCircumference(double x)
        {
            double cir = Math.PI * 2 * x;
            return cir;
        }
        public static void getFormattedCircumference(double x)
        {
            double cir = getCircumference(x);
            cir = Math.Round(cir, 2);
            Console.WriteLine("The circumference is " + cir);
        }
        public static double getArea(double x)
        {
            double area = x * x * Math.PI;
            return area;
        }
        public static void getFormattedArea(double x)
        {
            double area = getArea(x);
            area = Math.Round(area, 2);
            Console.WriteLine("The area is " + area);
        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();
            int circleCount = 1;

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                circleCount++;
                Console.WriteLine("Good Bye! You created "+circleCount+" circle(s)");
                
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
    }
}
