using FootballProject.TypeFootballer;

namespace FootballProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coach coachOne = new Coach("Grigori", 23);

            Team teamOne = new Team(coachOne, new List<FootballPlayer>
            {
                    new Defender("Player1",14,7,1.9f),
                    new Defender("Player12",14,7,1.9f),
                    new MidField("Player13",14,7,1.9f),
                    new MidField("Player14",14,7,1.9f),
                    new Defender("Player15",14,7,1.9f),
                    new Defender("Player16",14,7,1.9f),
                    new Defender("Player17",14,7,1.9f),
                    new GoalKeeper("Player18",14,7,1.9f),
                    new Striker("Player19",14,7,1.9f),
                    new MidField("Player29",14,7,1.9f),
                    new Striker("Player100",14,7,1.9f),
            });

            Team teamTwo = new Team(coachOne, new List<FootballPlayer>
            {
                    new Defender("Player2",14,7,1.9f),
                    new Defender("Player22",14,7,1.9f),
                    new Defender("Player23",14,7,1.9f),
                    new Defender("Player24",14,7,1.9f),
                    new Striker("Player25",14,7,1.9f),
                    new Striker("Player26",14,7,1.9f),
                    new MidField("Player27",14,7,1.9f),
                    new MidField("Player28",14,7,1.9f),
                    new MidField("Player29",14,7,1.9f),
                    new MidField("Player29",14,7,1.9f),
                    new GoalKeeper("Player200",14,7,1.9f),
            });

            Referee[] referees = {new Referee("Pesho",34), new Referee("Pencho", 34) };


            Game game = new Game(teamOne, teamTwo, new Referee("Niki", 25), referees);


            if(teamOne.GroupsChecking() == true && teamTwo.GroupsChecking() == true)
            {
                Console.WriteLine("Start match!!!");
                game.GameResult();
            }
            else
            {
                Console.WriteLine("The match was cancelled!");
            }
            
        }
    }
}