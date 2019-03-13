using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Primer01
{
    class Exercise01
    {

        static void NumberStats(double num)
        {
            Console.WriteLine("Stats for number: {0}", num);
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            if (num >= 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
            if (num % 1 > 0)
            {
                Console.WriteLine("Integer");
            }
            else
            {
                Console.WriteLine("Decimal");
            }
        }
        static bool UserInterface()
        {
            Console.Write("Please enter one number:\n");
            double number;
            bool isNumber = double.TryParse(Console.ReadLine(), out number);
            if (!isNumber)
            {
                Console.WriteLine("The entered is not a number! Please try again!");
                return false;
            }
            NumberStats(number);
            Console.Write("Press any key to try again or X to exit.");
            if (Console.ReadLine().ToUpper() == "X") return true;
            return false;
        }
        static void Main(string[] args)
        {
            while (!UserInterface()) ;
            Console.ReadLine();
        }
    }
}

