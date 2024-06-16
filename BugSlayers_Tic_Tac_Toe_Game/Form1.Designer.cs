namespace BugSlayers_Tic_Tac_Toe_Game
{
    partial class frmTicTacToeGame
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.lblPlayerWinScore = new System.Windows.Forms.Label();
            this.lblCPUWinScore = new System.Windows.Forms.Label();
            this.lblTicTacToe = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tmrCPU = new System.Windows.Forms.Timer(this.components);
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(93, 148);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(126, 111);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.PlayerMove);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(225, 148);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(126, 111);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.PlayerMove);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(357, 148);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(126, 111);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.PlayerMove);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(93, 265);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(126, 111);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.PlayerMove);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(225, 265);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(126, 111);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.PlayerMove);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(357, 265);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(126, 111);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.PlayerMove);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(93, 380);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(126, 111);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.PlayerMove);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(225, 380);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(126, 111);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.PlayerMove);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(357, 380);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(126, 111);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.PlayerMove);
            // 
            // lblPlayerWinScore
            // 
            this.lblPlayerWinScore.AutoSize = true;
            this.lblPlayerWinScore.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerWinScore.Location = new System.Drawing.Point(48, 105);
            this.lblPlayerWinScore.Name = "lblPlayerWinScore";
            this.lblPlayerWinScore.Size = new System.Drawing.Size(145, 29);
            this.lblPlayerWinScore.TabIndex = 9;
            this.lblPlayerWinScore.Text = "Player Wins:";
            // 
            // lblCPUWinScore
            // 
            this.lblCPUWinScore.AutoSize = true;
            this.lblCPUWinScore.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUWinScore.ForeColor = System.Drawing.Color.White;
            this.lblCPUWinScore.Location = new System.Drawing.Point(351, 105);
            this.lblCPUWinScore.Name = "lblCPUWinScore";
            this.lblCPUWinScore.Size = new System.Drawing.Size(124, 29);
            this.lblCPUWinScore.TabIndex = 10;
            this.lblCPUWinScore.Text = "CPU Wins:";
            // 
            // lblTicTacToe
            // 
            this.lblTicTacToe.AutoSize = true;
            this.lblTicTacToe.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacToe.ForeColor = System.Drawing.Color.White;
            this.lblTicTacToe.Location = new System.Drawing.Point(196, 52);
            this.lblTicTacToe.Name = "lblTicTacToe";
            this.lblTicTacToe.Size = new System.Drawing.Size(177, 36);
            this.lblTicTacToe.TabIndex = 11;
            this.lblTicTacToe.Text = "Tic-Tac-Toe";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(225, 528);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(126, 45);
            this.btnRestart.TabIndex = 12;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tmrCPU
            // 
            this.tmrCPU.Interval = 1000;
            this.tmrCPU.Tick += new System.EventHandler(this.CPUMove);
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.msMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Size = new System.Drawing.Size(616, 35);
            this.msMenuStrip.TabIndex = 13;
            this.msMenuStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 29);
            this.tsmiFile.Text = "File";
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.Size = new System.Drawing.Size(141, 34);
            this.tsmiFileExit.Text = "Exit";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(65, 29);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiHelpAbout
            // 
            this.tsmiHelpAbout.Name = "tsmiHelpAbout";
            this.tsmiHelpAbout.Size = new System.Drawing.Size(164, 34);
            this.tsmiHelpAbout.Text = "About";
            // 
            // frmTicTacToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(616, 620);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblTicTacToe);
            this.Controls.Add(this.lblCPUWinScore);
            this.Controls.Add(this.lblPlayerWinScore);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.msMenuStrip);
            this.MainMenuStrip = this.msMenuStrip;
            this.Name = "frmTicTacToeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label lblPlayerWinScore;
        private System.Windows.Forms.Label lblCPUWinScore;
        private System.Windows.Forms.Label lblTicTacToe;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer tmrCPU;
        private System.Windows.Forms.MenuStrip msMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpAbout;
    }
}

