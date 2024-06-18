using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSlayers_Tic_Tac_Toe_Game
{
    public class CheckGame
    {
        private GameCounter winCount;
        private RestartGame restartGame;
        private Timer CPUTimer;

        public bool GameOver { get;  set; } = false;

       

        private static readonly List<(int, int, int)> WinningCombinations = new List<(int, int, int)>
        {
            (0, 1, 2), // First row
            (3, 4, 5), // Second row
            (6, 7, 8), // Third row
            (0, 3, 6), // First column
            (1, 4, 7), // Second column
            (2, 5, 8), // Third column
            (0, 4, 8), // Diagonal from top-left to bottom-right
            (2, 4, 6)  // Diagonal from top-right to bottom-left
        };

        public CheckGame(GameCounter winCount, RestartGame restartGame, Timer CPUTimer)
        {
            this.winCount = winCount;
            this.restartGame = restartGame;
            this.CPUTimer = CPUTimer;
        }

        public void SetRestartGame(RestartGame restartGame)
        {
            this.restartGame = restartGame;
        }

        public void CheckWinOrDraw(List<Button> buttons, string playerSymbol)
        {
            if (HasWinningCombination(buttons, playerSymbol))
            {
                HandleWin(playerSymbol);
            }
            else if (IsDraw(buttons))
            {
                HandleDraw();
            }
        }

        private bool HasWinningCombination(List<Button> buttons, string playerSymbol)
        {
            return WinningCombinations.Any(combo =>
                buttons[combo.Item1].Text == playerSymbol &&
                buttons[combo.Item2].Text == playerSymbol &&
                buttons[combo.Item3].Text == playerSymbol);
        }

        private bool IsDraw(List<Button> buttons)
        {
            return buttons.All(b => !b.Enabled);
        }

        private void HandleWin(string playerSymbol)
        {
            CPUTimer.Stop();
            GameOver = true;

            if (playerSymbol == "X")
            {
                winCount.IncrementPlayerWins();
                winCount.UpdateScoreLabels();
                MessageBox.Show("Player Wins!");
            }
            else if (playerSymbol == "O")
            {
                winCount.IncrementCPUWins();
                winCount.UpdateScoreLabels();
                MessageBox.Show("CPU Wins!");
            }

           restartGame.ClearGame();
        }

        private void HandleDraw()
        {
            CPUTimer.Stop();
            GameOver = true;
            MessageBox.Show("It's a draw");
            restartGame.ClearGame();
        }

        public void ResetGameOver()
        {
            GameOver = false;
        }
    }
}