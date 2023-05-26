using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Game
{
    internal class Goal
    {
        public Goal(int minute, Football_player player)
        {
            Minute = minute;
            Player = player;
        }

        public int Minute { get; set; }
        public Football_player Player { get; set; }
    }
}
