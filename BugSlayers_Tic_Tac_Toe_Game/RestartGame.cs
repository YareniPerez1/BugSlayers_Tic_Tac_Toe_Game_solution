using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSlayers_Tic_Tac_Toe_Game
{
    //Rayleen's Class
    internal class RestartGame
    {
        public List<button> buttons = new List<button> { };

        public void Restart()
        { 
            foreach (button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = Color.Black;
            }
        }

    }
    
}


