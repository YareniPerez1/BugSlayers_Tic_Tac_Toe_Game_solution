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
    internal class RestartGame
    {
        public List<Button> buttons = new List<Button> { };

        public void Restart()
        { 
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = Color.Black;
            }
        }

    }
    
}


