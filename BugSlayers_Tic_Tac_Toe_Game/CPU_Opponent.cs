﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSlayers_Tic_Tac_Toe_Game
{
    public class CPU_Opponent : IPlayer
    {
        private List<Button> buttons;
        private Random random = new Random();
        private PlayerSymbol currentPlayer;

        public PlayerSymbol player { get; } = PlayerSymbol.O;

        public CPU_Opponent(PlayerSymbol symbol,
            List<Button> buttons)
        {
            this.currentPlayer = symbol;
            this.buttons = buttons;
        }

        public void UpdateButtons(List<Button> availableButtons)
        {
            this.buttons = availableButtons;
        }

        public void MakeMove()
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);

                buttons[index].Enabled = false;
                currentPlayer = player;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Gray;
                buttons.RemoveAt(index);

            }
        }
    }
}
