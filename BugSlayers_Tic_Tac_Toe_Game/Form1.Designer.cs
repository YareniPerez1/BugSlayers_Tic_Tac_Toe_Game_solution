namespace BugSlayers_Tic_Tac_Toe_Game
{
    partial class TicTacToeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.PlayerWinScore = new System.Windows.Forms.Label();
            this.CPUWinScore = new System.Windows.Forms.Label();
            this.lblTicTacToe = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 110);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 110);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 110);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 110);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 110);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(355, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 110);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(91, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 110);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(223, 334);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 110);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PlayerMove);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(355, 334);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 110);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PlayerMove);
            // 
            // PlayerWinScore
            // 
            this.PlayerWinScore.AutoSize = true;
            this.PlayerWinScore.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWinScore.Location = new System.Drawing.Point(47, 58);
            this.PlayerWinScore.Name = "PlayerWinScore";
            this.PlayerWinScore.Size = new System.Drawing.Size(104, 21);
            this.PlayerWinScore.TabIndex = 9;
            this.PlayerWinScore.Text = "Player Wins:";
            this.PlayerWinScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // CPUWinScore
            // 
            this.CPUWinScore.AutoSize = true;
            this.CPUWinScore.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUWinScore.Location = new System.Drawing.Point(450, 58);
            this.CPUWinScore.Name = "CPUWinScore";
            this.CPUWinScore.Size = new System.Drawing.Size(88, 21);
            this.CPUWinScore.TabIndex = 10;
            this.CPUWinScore.Text = "CPU Wins:";
            // 
            // lblTicTacToe
            // 
            this.lblTicTacToe.AutoSize = true;
            this.lblTicTacToe.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacToe.Location = new System.Drawing.Point(204, 19);
            this.lblTicTacToe.Name = "lblTicTacToe";
            this.lblTicTacToe.Size = new System.Drawing.Size(177, 36);
            this.lblTicTacToe.TabIndex = 11;
            this.lblTicTacToe.Text = "Tic-Tac-Toe";
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(223, 482);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(126, 44);
            this.RestartButton.TabIndex = 12;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            // 
            // CPUTimer
            // 
            this.CPUTimer.Interval = 1000;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUMove);
            // 
            // TicTacToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 566);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.lblTicTacToe);
            this.Controls.Add(this.CPUWinScore);
            this.Controls.Add(this.PlayerWinScore);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TicTacToeGame";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToeGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label PlayerWinScore;
        private System.Windows.Forms.Label CPUWinScore;
        private System.Windows.Forms.Label lblTicTacToe;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Timer CPUTimer;
    }
}

