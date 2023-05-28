using FootballProject.TypeFootballer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballProject
{
    internal class Game
    {
        private const int MATCH_TIME = 90;
        private Team TeamOne { get; set; }
        private Team TeamTwo;

        private readonly Referee Referee;
        private readonly Referee[] assistants = new Referee[2];

        public Game(Team teamOne, Team teamTwo, Referee referee, Referee[] assistants)
        {
            TeamOne = teamOne;
            TeamTwo = teamTwo;
            Referee = referee;

            this.assistants = assistants;
        }
        private string Goal(int minute, FootballPlayer player)
        {
            return $"\nPlayer{player.Number}({player.Name}) form the team score a goal at {minute}";
        }
        public void GameResult()
        {
            Random timeRand = new Random();
            Random teamRand = new Random();
            Random playerRand = new Random();

            int countTeamOne=0,countTeamTwo=0;


            for (int i = 1; i < MATCH_TIME; i++)
            {
                int time = timeRand.Next(1, 90);

                int team = teamRand.Next(0, 1);

                if(time == i && team == 0)
                {
                    FootballPlayer player = TeamOne.teamPlayers.Where(x => x.GetType() != typeof(GoalKeeper))
                                                               .ElementAt(playerRand.Next(0,TeamTwo.teamPlayers.Count - 1));
                    Console.WriteLine(Goal(i,player));
                    countTeamOne++;
                }
                else if(time == i && team == 1)
                {
                    FootballPlayer player = TeamTwo.teamPlayers.Where(x => x.GetType() != typeof(GoalKeeper))
                                                               .ElementAt(playerRand.Next(0,TeamTwo.teamPlayers.Count-1));
                    Console.WriteLine(Goal(i, player));
                    countTeamOne++;
                }
            }
            CheckWinner(countTeamOne, countTeamTwo);

        }
        private void CheckWinner(int countTeamOne, int countTeamTwo)
        {
            if (countTeamOne == countTeamTwo)
            {
                Console.WriteLine($"\nTie\nScore: Team 1({countTeamOne})-Team 2({countTeamTwo})");
            }
            else if (countTeamOne > countTeamTwo)
            {
                Console.WriteLine($"\nTeam 1 WIN!!\nScore: Team 1({countTeamOne})-Team 2({countTeamTwo})");
            }
            else
            {
                Console.WriteLine($"\nTeam 2 WIN!!\nScore: Team 1({countTeamOne})-Team 2({countTeamTwo})");
            }
        }
    }
}
