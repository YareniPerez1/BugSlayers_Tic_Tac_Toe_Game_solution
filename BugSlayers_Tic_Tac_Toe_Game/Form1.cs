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
        }


        private void CPUMove(object sender, EventArgs e)
        {
            // Example part where CPU wins
            if (CheckWinner("O"))
            {
                gameCounter.IncrementCPUWins();
                UpdateScoreLabels();
                MessageBox.Show("CPU Wins!");
               //(Made in anticipation of Rayleen's part) RestartGame();
            }
        }


        private void PlayerMove(object sender, EventArgs e)
        {
            //this is player click button in yareni's example.

             if (CheckWinner("X"))
            {
                gameCounter.IncrementPlayerWins();
                UpdateScoreLabels();
                MessageBox.Show("Player Wins!");
                //(Made in anticipation of Rayleen's part) RestartGame();
            }
        }

        private void UpdateScoreLabels()
        {
            lblPlayerWinScore.Text = "Player Wins: " + gameCounter.PlayerWins;
            lblCPUWinScore.Text = "CPU Wins: " + gameCounter.CPUWins;
        }

      

        private bool CheckWinner(string player)
        {
            // Check rows, columns, and diagonals for a win
            return (btn1.Text == player && btn2.Text == player && btn3.Text == player) ||
                   (btn4.Text == player && btn5.Text == player && btn6.Text == player) ||
                   (btn7.Text == player && btn8.Text == player && btn9.Text == player) ||
                   (btn1.Text == player && btn4.Text == player && btn7.Text == player) ||
                   (btn2.Text == player && btn5.Text == player && btn8.Text == player) ||
                   (btn3.Text == player && btn6.Text == player && btn9.Text == player) ||
                   (btn1.Text == player && btn5.Text == player && btn9.Text == player) ||
                   (btn3.Text == player && btn5.Text == player && btn7.Text == player);
        }





        private void TicTacToeGame_Load(object sender, EventArgs e)
        {
            // Initialize the scores

        }
        private void label1_Click(object sender, EventArgs e)
        { //ignore accidently added

        }
    }
}
