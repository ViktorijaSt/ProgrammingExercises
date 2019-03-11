using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseObjects
{
    class Program
    {
        class Dog
        {
            public string Name;
            public string Race;
            public string Color;
            public int Age;
            public void PrintKuce()
            {
                Console.WriteLine("Dog's name is {0}. He is {1} with {2} color and is {3} years old.", this.Name,
                    this.Race, this.Color, this.Age);
            }

            public void Eat()
            {
                Console.WriteLine("The dog now is eating");
            }
            public void Play()
            {
                Console.WriteLine("The dog whants to play");
            }
            public void ChaseTail()
            {
                Console.WriteLine("Dog now is chasing its tail");
            }
            public Dog(string Name, string Race, string Color, int Age) //constructor - public, isto ime kako class

            {
                this.Name = Name;
                this.Race = Race;
                this.Color = Color;
                this.Age = Age;
            }
        }
        class Human  //class Human - creating in class Program
        {
            public string FirstName;  //adding properties - with public and data type(string, int, bool..)
            public string LastName;
            public int Age;
            public void PersonalInfo() // adding method - with public void, name of method and ();
            {
                Console.WriteLine("Full name of this human is: {0} {1} and his age is {2}.",
                    this.FirstName, this.LastName, this.Age); // what this method returns
            }

        }
        static void Main(string[] args)

        {
            Human covek = new Human();  // creating object "covek"-name of object, new and with Human();
            covek.FirstName = "Sebastijan"; //adding info for properties
            covek.LastName = "Warner";
            covek.Age = 38;
            covek.PersonalInfo(); //calling method and printing
            Console.ReadLine();

            //Dog kuce = new Dog("Dzeki", "dalmatinec", "shareno", 1);
            //kuce.PrintKuce(kuce);
            Dog doggy = new Dog("Dzeki", "dalmatinec", "shareno", 1);
            doggy.Name = "Itan";
            doggy.Race = "terier";
            doggy.Color = "white";
            doggy.Age = 5;
            doggy.PrintKuce();
            Console.WriteLine("What the dog is doing now?");
            string playing = Console.ReadLine();

            if (playing == "play")
            {
                doggy.Play();
            }
            else
            {
                Console.WriteLine("Dog is watching TV");
            }
            Console.WriteLine("Is it hungry?");
            string eating = Console.ReadLine();
            if (eating == "eating")
            {
                doggy.Eat();
            }
            else
            {
                Console.WriteLine("This dog don't whan to eat");
            }
            Console.WriteLine("Is it chase his tail?");
            string chase = Console.ReadLine();
            if (chase == "Chase Tail")
            {
                doggy.ChaseTail();
            }
            else
            {
                Console.WriteLine("Not chase the tail");
            }
            Console.ReadLine();
        }
    }
}
