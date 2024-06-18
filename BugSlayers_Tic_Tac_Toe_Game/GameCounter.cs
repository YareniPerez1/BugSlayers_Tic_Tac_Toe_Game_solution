using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace BugSlayers_Tic_Tac_Toe_Game
{
    public class GameCounter
    {
        public int PlayerWins  { get; private set; }
        public int CPUWins { get; private set; }
       private Label lblPlayerWinScore;
        private Label lblCPUWinScore;


        public GameCounter(Label lblPlayerWinScore, Label lblCPUWinScore)
        {
            this.lblPlayerWinScore = lblPlayerWinScore;
            this.lblCPUWinScore = lblCPUWinScore;
        }
        //public GameCounter()
        //{
        //    PlayerWins = 0;
        //    CPUWins = 0;
        //}

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
        

      

        public void UpdateScoreLabels()
        {

            lblPlayerWinScore.Text = "Player Wins: " + PlayerWins;
            lblCPUWinScore.Text = "CPU Wins: " +CPUWins;

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