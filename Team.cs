using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Game
{
    internal class Team
    {
        public Team(Coach coach, string name, List<Football_player> players)
        {
            Coach = coach;
            Name = name;
            Players = players;
        }

        public Coach Coach { get; set; }
        public string Name { get; set; }
        public List<Football_player> Players { get; set; }

        
        public double CalculateAvgAge()
        {
            double totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }
            return totalAge / Players.Count;
        }

    }
}
