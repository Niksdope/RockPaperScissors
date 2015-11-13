namespace RockPaperScissors
{
    partial class Form1
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
            this.Score = new System.Windows.Forms.Label();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Label();
            this.Computer = new System.Windows.Forms.Label();
            this.scorePlayer = new System.Windows.Forms.Label();
            this.scoreComputer = new System.Windows.Forms.Label();
            this.semiColon = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(276, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(228, 79);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score";
            this.Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Scissors.Image = global::RockPaperScissors.Properties.Resources.scissors;
            this.Scissors.Location = new System.Drawing.Point(546, 314);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(188, 205);
            this.Scissors.TabIndex = 4;
            this.Scissors.UseVisualStyleBackColor = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Paper.BackgroundImage = global::RockPaperScissors.Properties.Resources.black_nice_background;
            this.Paper.Image = global::RockPaperScissors.Properties.Resources.Paper;
            this.Paper.Location = new System.Drawing.Point(299, 314);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(188, 205);
            this.Paper.TabIndex = 1;
            this.Paper.UseVisualStyleBackColor = false;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Rock
            // 
            this.Rock.Image = global::RockPaperScissors.Properties.Resources.Narararr;
            this.Rock.Location = new System.Drawing.Point(50, 314);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(188, 205);
            this.Rock.TabIndex = 0;
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player.Location = new System.Drawing.Point(247, 109);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(82, 23);
            this.player.TabIndex = 6;
            this.player.Text = "Player";
            // 
            // Computer
            // 
            this.Computer.AutoSize = true;
            this.Computer.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computer.Location = new System.Drawing.Point(453, 109);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(113, 23);
            this.Computer.TabIndex = 7;
            this.Computer.Text = "Computer";
            // 
            // scorePlayer
            // 
            this.scorePlayer.AutoSize = true;
            this.scorePlayer.BackColor = System.Drawing.Color.White;
            this.scorePlayer.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePlayer.Location = new System.Drawing.Point(293, 152);
            this.scorePlayer.Name = "scorePlayer";
            this.scorePlayer.Size = new System.Drawing.Size(36, 33);
            this.scorePlayer.TabIndex = 8;
            this.scorePlayer.Text = " 0";
            // 
            // scoreComputer
            // 
            this.scoreComputer.AutoSize = true;
            this.scoreComputer.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreComputer.Location = new System.Drawing.Point(451, 152);
            this.scoreComputer.Name = "scoreComputer";
            this.scoreComputer.Size = new System.Drawing.Size(36, 33);
            this.scoreComputer.TabIndex = 9;
            this.scoreComputer.Text = "0 ";
            this.scoreComputer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // semiColon
            // 
            this.semiColon.BackColor = System.Drawing.Color.Transparent;
            this.semiColon.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semiColon.ForeColor = System.Drawing.Color.Red;
            this.semiColon.Location = new System.Drawing.Point(382, 152);
            this.semiColon.Name = "semiColon";
            this.semiColon.Size = new System.Drawing.Size(21, 33);
            this.semiColon.TabIndex = 10;
            this.semiColon.Text = ":";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.White;
            this.scoreText.Location = new System.Drawing.Point(271, 256);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 23);
            this.scoreText.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RockPaperScissors.Properties.Resources.black_nice_background1;
            this.ClientSize = new System.Drawing.Size(780, 541);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.semiColon);
            this.Controls.Add(this.scoreComputer);
            this.Controls.Add(this.scorePlayer);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label Computer;
        private System.Windows.Forms.Label scorePlayer;
        private System.Windows.Forms.Label scoreComputer;
        private System.Windows.Forms.Label semiColon;
        private System.Windows.Forms.Label scoreText;
    }
}

