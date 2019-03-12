using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public string FirstName;
        public string LastName;
        public int Score;
        public Player()
        {
            this.Score = 0;
        }
        public void FullName()
        {
            Console.WriteLine("This player is: {0}, {1}.", this.FirstName, this.LastName);
        }
        public Player (string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

    }
}
