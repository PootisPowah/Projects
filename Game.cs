using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Game
{
    internal class Game
    {
        public Game(Team team1, Team team2, Referee @ref, List<AssistantReferee> assistantReferees)
        {
            Team1 = team1;
            Team2 = team2;
            Ref = @ref;
            AssistantReferees = assistantReferees;
            Goals = new List<Goal>();
            
        }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Ref { get; set; }
         public List<AssistantReferee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }

        public string Result { get; set; }
        public Team Winner { get; set; }

        public void StartGame()
        {
            Console.WriteLine("The game is starting!");
            Console.WriteLine("...3...");
            Console.WriteLine("...2...");
            Console.WriteLine("...1...");
            Console.WriteLine("...START!...");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"Team 1's name is: {Team1.Name} - Coach: {Team1.Coach.Name}" +
                $" - Average player age: {Math.Round(Team1.CalculateAvgAge())}");
            Console.WriteLine($"Team 2's name is: {Team2.Name} - Coach: {Team2.Coach.Name}" +
                $" - Average player age: {Math.Round(Team2.CalculateAvgAge())}");
            Console.WriteLine($"Referee is: {Ref.Name}");
            Console.Write($"Assistant referees are: {string.Join(", ", AssistantReferees.Select(assRefs => assRefs.Name))}");

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            Random rand = new Random();
            int totalGoals = rand.Next(0,6);
            int timeVar = 1;
            for (int i = 0; i < totalGoals; i++)
            {
                int minute = rand.Next(timeVar, 91); 
                int teamIndex = rand.Next(0, 2); 
                Team scoringTeam = (teamIndex == 0) ? Team1 : Team2;
                Football_player scorer = scoringTeam.Players[rand.Next(scoringTeam.Players.Count)];
                Goals.Add(new Goal(minute, scorer));
                timeVar=minute;
            }

            int team1Goals = Goals.FindAll(g => g.Player is Football_player && Team1.Players.Contains(g.Player)).Count;
            int team2Goals = Goals.FindAll(g => g.Player is Football_player && Team2.Players.Contains(g.Player)).Count;
            Result = $"{team1Goals} - {team2Goals}";

            if (team1Goals > team2Goals)
            {
                Winner = Team1;
            }
            else if (team1Goals < team2Goals)
            {
                Winner = Team2;
            }
            else 
            {
                Winner = null;
            }
            int count = 1;
            if (Goals.Count > 0)
            {
                Console.WriteLine("Goals: ");
                foreach (var goal in Goals)
                {
                    if (Goals.Count > 0)
                    {
                        Console.WriteLine($"Goal number {count} -> Minute: {goal.Minute} - Scorer: {goal.Player.Name}");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("No Goals");
                    }
                }
            }
            

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Result: {Result}");
            Console.WriteLine($"Winner: {(Winner != null ? Winner.Name: "Draw")} ");
            Console.WriteLine("END OF GAME!");
            Console.WriteLine("-----------------------------------");
        }
    }
}
