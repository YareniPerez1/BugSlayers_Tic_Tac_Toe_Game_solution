using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSlayers_Tic_Tac_Toe_Game
{
    //Rayleen's Class
    public class RestartGame
    {
        public List<Button> buttons = new List<Button> { };
        private CheckGame checkGame;

        public RestartGame(List<Button> buttons , CheckGame checkGame)
        {
            this.buttons = buttons;
            this.checkGame = checkGame;


        }




        public void ClearGame()
        {

            if (checkGame.GameOver == true)
            {
                checkGame.GameOver = false;
            }

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = Color.Black;
            }
        }

    }
    
}


