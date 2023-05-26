using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Game
{
    internal class Football_player:Person
    {
        public Football_player(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height= height;
        }

        public int Number { get; set; }
        public double Height { get; set; }
    }
}
