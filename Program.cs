using System;

namespace CsharpProj1
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Circle Value Calculator\n\n");
            calc();

        }
        static void calc()
        {
            try
            {
                string piQ = piQuery();
                double pi = Math.PI;
                if (piQ == "" || piQ.ToLower() == "n")
                {
                    pi = Math.PI;
                }
                else if (piQ.ToLower() == "y")
                {
                    pi = 3.14;
                }
                else
                {
                    Console.WriteLine("Please type Y or N");
                    piQuery();
                }
                Console.Write("Input radius here: ");
                string input = Console.ReadLine();
                double radius = double.Parse(input);
                double diameter = radius * 2;
                Console.WriteLine($"Circumference: {pi * diameter} units\nDiameter: {diameter} units\nArea: {pi * (radius * radius)} units\n\n");
                Console.Write("Press enter to quit");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please input a number");
                calc();
            }
        }
        static string piQuery()
        {
            Console.Write("Use 3.14 for pi?(y/N) ");
            string piQ = Console.ReadLine();
            return piQ;
        }
    }
   
}
