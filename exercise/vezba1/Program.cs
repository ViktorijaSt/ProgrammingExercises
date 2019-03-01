using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 100)


            //Console.WriteLine("Thoese number " + $"{i}" + " are odd");
            //i = i % 2 != 0;


            //Console.WriteLine();
            //Console.ReadLine();

            //int i, n, sum;
            //sum = 0;
            //n = int.Parse(Console.ReadLine());
            //for (i = 1; i <= n; ++i)
            //{
            //    sum += i;   // sum = sum+i;
            //}

            //Console.WriteLine(sum);

            //Console.ReadLine();
            //Console.WriteLine("This are the element of my array ");
            //string[] days;
            //days = new string[7] { "Mo", "Vt", "Sr", "Ce", "Pe", "Sa", "Ne" };
            //days[0] = "Mo";
            //days[1] = "Vt";
            //days[2] = "Sr";
            //days[3] = "Ce";
            //days[4] = "Pe";
            //days[5] = "Sa";
            //days[6] = "Ne";
            //foreach (string day in days)
            //    Console.WriteLine(day + " ");


            //int broj1, broj2;
            //Console.WriteLine("Tell me one number?");
            //string x = Console.ReadLine();
            //broj1 = Convert.ToInt32(x);

            //Console.WriteLine("Tell me second number?");
            //string y = Console.ReadLine();
            //broj2 = Convert.ToInt32(y);
            //if (broj1 > broj2)

            //{
            //    Console.WriteLine("First number is lagrer then second number.");
            //}
            //else
            //{
            //    Console.WriteLine("Second number is larger then first.");
            //}

            //    if (broj1 % 2 == 0)
            //{
            //    Console.WriteLine("First number is positive number.");
            //}
            //    else
            //{
            //    Console.WriteLine("First number is odd number");
            //}
            //    if (broj2 % 2 == 0)
            //{
            //    Console.WriteLine("Second number is positive number.");
            //}
            //else
            //{
            //    Console.WriteLine("Second number is odd number");
            //}


            //Console.ReadLine();

            //Console.WriteLine("Please, enter number from 1 to 3.");
            //int inputNum;
            //string x = Console.ReadLine();
            //inputNum = int.Parse(x);


            //switch (inputNum)
            //{
            //    case 1:
            //        Console.WriteLine("You got a car.");
            //        break;

            //    case 2:

            //    Console.WriteLine("You got a plane.");
            //    break;
            //    case 3:

            //        Console.WriteLine("You got a boat.");
            //        break;

            //    default:
            //        Console.WriteLine("That is not a option!");
            //        break;
            //}
            //Console.ReadLine();

            //Console.WriteLine("Please, enter number..");
            //int inputNum;
            //string x = Console.ReadLine();
            //inputNum = int.Parse(x);

            Console.WriteLine("Welcome to the simple basic calculator.");
            string operation;
            int answer;

            Console.WriteLine("Enter the first number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ok now enter your operation ( x , / , +, -) ");
            operation = Console.ReadLine();

            Console.WriteLine("Please, enter another number..");
            int inputNum2 = Convert.ToInt32(Console.ReadLine());

            if (operation == "x")
            {
                answer = inputNum * inputNum2;
                Console.WriteLine("Result from your operations is: " + inputNum + " x " + inputNum2 + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = inputNum / inputNum2;
                Console.WriteLine("Result from your operations is: " + inputNum + " / " + inputNum2 + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                answer = inputNum + inputNum2;
                Console.WriteLine("Result from your operations is: " + inputNum + " + " + inputNum2 + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = inputNum - inputNum2;
                Console.WriteLine("Result from your operations is: " + inputNum + " - " + inputNum2 + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry that is not correct format! Please restart!");
                Console.ReadLine();
            }
            //Console.WriteLine("Welcome to my currency conversion toll!");

            //    int input;
            //    decimal answer;
            //    string currency;

            //    Console.WriteLine("Please, enter amount in denars:");
            //    input = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter currency to convert to: write EUR, USD or GBP:");
            //    currency = Console.ReadLine();

            //    if (currency == "EUR")
            //    {
            //        answer = Math.Round((input / 61.8m),2);
            //        Console.WriteLine(input +" denars are "+ answer + " EUR.");
            //        Console.ReadLine();
            //    }
            //    else if (currency == "USD")
            //    {
            //        answer = Math.Round((input / 54.8m), 2);
            //        Console.WriteLine(input + " denars are " + answer + " USD.");
            //        Console.ReadLine();
            //    }
            //    else if (currency == "GBP")
            //    {
            //        answer = Math.Round((input / 72.6m), 2);
            //        Console.WriteLine(input + " denars are " + answer + " GBP.");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("There isn't such a option. Please repeat your entry!");
            //        Console.ReadLine();
            //    }


        }



    }

}

