using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersandTeamsProjwct
{
    public class Program
    {
        static void Main(string[] args)
        {
         OnedayTeam team = new OnedayTeam();
         
            while (true)
            {
                Console.WriteLine("Enter \n1: Add Player to Team \n2: To Remove Player from Team \n3: Get Player By ID \n4: Get Player By Name \n5: Get All Players \n6: Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        EnterPlayerDetails(team);
                        break;
                    case 2:
                        PlayerRemovefromTeam(team);
                        break;
                    case 3:
                        GetPlayerNameById(team);
                        break;
                    case 4:
                        GetPlayerInfoByName(team);
                        break;
                    case 5:
                        GetAllPlayers();
                        break;
                    case 6:
                        Environment.Exit(0);    
                        break;
                }
            }
               Console.ReadLine();
        }

        public static void GetAllPlayers()
        {
            OnedayTeam t = new OnedayTeam();
            List<Player> allPlayers = t.GetAllPlayers();
            if (allPlayers.Count > 0)
            {
                Console.WriteLine("All Players :\n ");
                foreach (var p in allPlayers)
                {
                    Console.WriteLine($"PlayerID: {p.PlayerId}\nPlayerName: {p.PlayerName}\nPlayer Age: {p.PlayerAge}");
                }
            }
            else
            {
                Console.WriteLine("No Players in the Team: ");
            }
        }

        private static void GetPlayerInfoByName(OnedayTeam team)
        {
            Console.WriteLine("Enter the Name of Player: ");
            string retname = Console.ReadLine();
            Player Byname = team.GetPlayerByName(retname);
            Console.WriteLine(Byname != null ? $"Player found : {Byname.PlayerName}" : "Player not found: ");
        }

        private static void GetPlayerNameById(OnedayTeam team)
        {
            Console.WriteLine("Enter Player Id To Retreive The Player Name: ");
            int retName = Convert.ToInt32(Console.ReadLine());
            Player planame = team.GetPlayerById(retName);
            Console.WriteLine(planame!=null ? $"Player Found : {planame.PlayerName}":"Player not found");
        }

        private static void PlayerRemovefromTeam(OnedayTeam team)
        {
            Console.WriteLine("Enter Player Id to Remove: ");
            int removeid = Convert.ToInt32(Console.ReadLine());
            team.Remove(removeid);
        }

        private static void EnterPlayerDetails(OnedayTeam team)
        {
            Console.WriteLine("Enter Player Id: ");
            int playerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Player Name: ");
            string playername = Console.ReadLine();
            Console.WriteLine("Enter Player Age: ");
            int playerAge = Convert.ToInt32(Console.ReadLine());

            Player p = new Player
            {
                PlayerId = playerId,
                PlayerName = playername,
                PlayerAge = playerAge
            };
            team.Add(p);
        }
    }
}
