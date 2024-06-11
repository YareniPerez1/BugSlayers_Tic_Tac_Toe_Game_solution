using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSlayers_Tic_Tac_Toe_Game
{

    public enum PlayerSymbol
    {
        X, O

    }
    public interface IPlayer
    {
        PlayerSymbol player { get; }

    }
    
}
