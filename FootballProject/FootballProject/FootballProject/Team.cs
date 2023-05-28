using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballProject.TypeFootballer;

namespace FootballProject
{

    internal class Team
    {
        public Coach TeamCoach { get; set; }
        public List<FootballPlayer> teamPlayers;
        private List<FootballPlayer> TeamPlayers { get { return teamPlayers; } set
            {
             bool isKeeperIn = false;
             foreach (var player in value)
                {
                    if (player.GetType() == typeof(GoalKeeper))
                    {
                        isKeeperIn = true;
                        teamPlayers = value;
                    }
                }
             if(isKeeperIn)
                {
                    value.Add(new GoalKeeper("Bot",0,0,0));
                    teamPlayers = value;
                }
             
            }
        }
        public float AverageAge { get {  return GetAverageAge(); } }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            TeamCoach = coach;
            TeamPlayers = players;
        }

        private float GetAverageAge()
        {
            float averageAge = 0f;
            foreach(var player in teamPlayers)
            {
                averageAge += player.Age;
            }
            return averageAge/teamPlayers.Count;
        }
        
        public bool GroupsChecking()
        {
            if (teamPlayers.Count >= 11 && teamPlayers.Count <= 22)
            {
                return true;
            }
            return false;
        }
    }
}
