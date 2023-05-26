namespace Football_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football_player[] players1 = new Football_player[]
            {
                new Goalkeeper("Aleksandar  Gerdzhikov", 26, 1, 1.69),
                new Defender("Aleksandar Donchev", 27, 2, 1.77),
                new Defender("Stanislav Stratiev", 31, 3, 1.80),
                new Defender("Yordan Radichkov", 25, 4, 1.81),
                new Defender("Ivan Vazov", 28, 5, 1.76),
                new Striker("Hristo Botev", 23, 6, 1.75),
                new Striker("Martin Shirtev", 25, 7, 1.83),
                new Striker("Elin Pelin", 28, 8, 1.82),
                new Midfield("Peyo Yavorov", 24, 9, 1.77),
                new Midfield("Hristo Fotev", 25, 10, 1.85),
                new Midfield("Momchil Kemalov", 29, 11, 1.85)
            };

            Football_player[] players2 = new Football_player[]
             {
                new Goalkeeper("Christiyan Kraev", 25, 1, 1.85),
                new Defender("Daniel Stoev", 28, 2, 1.95),
                new Defender("Petur Beron", 30, 3, 1.82),
                new Defender("Hristiyan Baev", 24, 4, 1.79),
                new Striker("Atanas Kolev", 23, 5, 1.84),
                new Striker("Atanas Mentata", 28, 6, 1.83),
                new Striker("Kiril Nikolov", 24, 7, 1.91),
                new Striker("Aleksandur Stoyanov", 8, 1, 1.85),
                new Midfield("Daniel Petrov", 28, 9, 1.80),
                new Midfield("Nikolai Nikolov", 24, 10, 1.90),
                new Midfield("Boris lazarov", 26, 1, 1.78)
             };


            Coach[] coaches = new Coach[]
            {
                new Coach("Teodora Atanasova", 45),
                new Coach("Nikol Lozanova", 50)
            };

            Team[] teams = new Team[]
            {
                new Team(coaches[0], "CSKA", new List<Football_player> (players1[0..11])),
                new Team(coaches[1], "LEVSKI", new List<Football_player>  (players2[0..11])),
            };

            Game[] games = new Game[]
            {
                new Game(teams[0], teams[1], new Referee("John Atanasov", 40), new List <AssistantReferee> { new AssistantReferee("Christian Dior", 35), new AssistantReferee("Sara Zaharieva", 32) }),
                new Game(teams[1], teams[0], new Referee("Mihail Iliyadov", 38), new List<AssistantReferee> { new AssistantReferee("Alex Murlqv", 36), new AssistantReferee("Daniel Yonchev", 33) })
            };

            int count = 1;
            foreach (var game in games)
            {
                Console.WriteLine("Game Number: " + count);
                game.StartGame();

                Console.WriteLine("Match Result: " + game.Result);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                count++;
            }
        }
    }
}