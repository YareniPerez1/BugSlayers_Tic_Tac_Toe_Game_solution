using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSlayers_Tic_Tac_Toe_Game
{
    public partial class frmTicTacToeGame : Form
    {
        private GameCounter gameCounter;  // Add GameCounter instance
        public frmTicTacToeGame()
        {
            InitializeComponent();
            gameCounter = new GameCounter();  // Initialize GameCounter
            UpdateScoreLabels();
        }

        public void IncrementPlayerWins()
        {
            gameCounter.IncrementPlayerWins();
            UpdateScoreLabels();
        }

        public void IncrementCPUWins()
        {
            gameCounter.IncrementCPUWins();
            UpdateScoreLabels();
        }

        private void UpdateScoreLabels()
        {

            lblPlayerWinScore.Text = gameCounter.GetPlayerWins();
            lblCPUWinScore.Text = gameCounter.GetCPUWins();

        }
        private void CPUMove(object sender, EventArgs e)
        {
            

        }


        private void PlayerMove(object sender, EventArgs e)
        {
            //this is player click button in yareni's example.


        }
    }
}

 