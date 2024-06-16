using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSlayers_Tic_Tac_Toe_Game
{
    public class HumanPlayer : IPlayer
    {

        public PlayerSymbol player { get; }

       

        public HumanPlayer(PlayerSymbol symbol)
        {
            this.player = symbol;

        }

        public void MakeMove()
        {



        }
    }
}
