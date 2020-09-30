using System;
using System.Runtime.InteropServices.ComTypes;

namespace CircleAreaFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user for input and calculates area, circumference, and diameter of the circle.
            Console.Write("Enter a radius: ");
            string input = Console.ReadLine();
            double radius;
            bool result = Double.TryParse(input, out radius);
            if (result.Equals(false))
            {
                Console.WriteLine("The value you provided is not a number, program closing.");
                Environment.Exit(0);
            }
            else {
            while (radius > 0) {
            double area = (Math.Pow(radius, 2) * (Math.PI));
            Console.WriteLine("The area of a circle with a radius of " + radius + "is: " + area);
            double circumference = (Math.PI * radius * 2);
            Console.WriteLine("The circumference of a circle with a radius of " + radius + " is: " + circumference);
            Console.WriteLine("The Diameter of a circle with a radius of " + radius + "is: " + (radius * 2));
            Console.Write("What is the MPG of your vehicle?");
            double mpg = Int32.Parse(Console.ReadLine());
            double fuelRequired = (circumference / mpg);
            Console.WriteLine("If the above radius is in miles, it would take " + fuelRequired + " Gallons of gasoline to travel around the circle.");
             Console.Write("Please enter a radius: ");
             radius = Int32.Parse(Console.ReadLine());
            }
            }
        }
        static void Circle(string[] args)
        {

        }
    }
}
