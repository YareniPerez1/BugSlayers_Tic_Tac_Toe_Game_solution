using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSlayers_Tic_Tac_Toe_Game
{
    public class GameCounter
    {
        public int PlayerWins { get; private set; }
        public int CPUWins { get; private set; }

        public GameCounter()
        {
            PlayerWins = 0;
            CPUWins = 0;
        }

        public void IncrementPlayerWins()
        {
            PlayerWins++;
        }

        public void IncrementCPUWins()
        {
            CPUWins++;
        }

        public void Reset()
        {
            PlayerWins = 0;
            CPUWins = 0;
        }

        public string GetPlayerWins()
        {
            return "Player Wins: " + PlayerWins;
        }

        public string GetCPUWins()
        {
            return "CPU Wins: " + CPUWins;
        }
    }
}