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

        private HumanPlayer player;
        private List<Button> buttons;
        public frmTicTacToeGame()
        {
            InitializeComponent();

            buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            player = new HumanPlayer(PlayerSymbol.X);
        }

       

        private void CPUMove(object sender, EventArgs e)
        {

        }

        private void PlayerMove(object sender, EventArgs e)
        {
            //this is player click button in yareni's example.


            var button = (Button)sender;

            button.Text = player.player.ToString();
            button.Enabled = false;
            button.BackColor = Color.DarkSeaGreen;
            tmrCPU.Start();
        }










        
       
    }
}
