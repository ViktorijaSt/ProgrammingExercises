using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseClass06
{
    class Program
    {
       
         

        static void Main(string[] args)
        {
            public void NumberStats(double num)
            {
                //Console.WriteLine("Please enter one number:\n");
                //string x = Console.ReadLine();
                //num = Convert.ToInt32(x);
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
                //static bool UserInterface()
                //{
                //    Console.Write("Enter a number:");
                //    //double num;
                //    bool isNumber = double.TryParse(Console.ReadLine(), out num);
                //    if (!isNumber)
                //    {
                //        Console.WriteLine("That was not a number! Please try again!");
                //        return false;
                //    }
                //    NumberStats(num);
                //    Console.Write("Press any key to try again or X to exit.");
                //    if (Console.ReadLine().ToUpper() == "X") return true;
                //    return false;
                //while (!UserInterface()) ;
                Console.ReadLine();
        }
    }
}
