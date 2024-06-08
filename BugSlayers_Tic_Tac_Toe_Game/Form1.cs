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
        public frmTicTacToeGame()
        {
            InitializeComponent();
        }

       

        private void CPUMove(object sender, EventArgs e)
        {

        }

        private void PlayerMove(object sender, EventArgs e)
        {
            //this is player click button in yareni's example.
        }


        private void tsmiHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rules for Tic-Tac-Toe\r\n\r\n1. The game is played on a grid that's 3 squares by 3 squares.\r\n\r\n2. You are X , your friend (or the computer) is O . Players take turns putting their marks in empty squares.\r\n\r\n3. The first player to get 3 of their marks in a row (up, down, across, or diagonally) is the winner.\r\n\r\n4. When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.", "About Tic Tac Toe");
        }

    }
}
