using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersandTeamsProjwct
{
    public class OnedayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OnedayTeam()
        {

        }
        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player Added To The Team Successfully: ");
            }
            else
            {
                Console.WriteLine("The team is already full. Cann't add more Players:");
            }
        }
        public void Remove(int playerId)
        {
            Player playerToremove = oneDayTeam.Find(p => p.PlayerId == playerId);
            if (playerToremove != null)
            {
                oneDayTeam.Remove(playerToremove);
                Console.WriteLine("Player Removed From The Team: ");
            }
            else
            {
                Console.WriteLine("Player not found in the Team: ");
            }
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(p => p.PlayerId == playerId);
        }
        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(p => p.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
           return oneDayTeam;
        }      
    }
}
