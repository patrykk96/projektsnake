namespace Projekt_Snake
{
    partial class formSnakeGame
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelGameOverText = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreString = new System.Windows.Forms.Label();
            this.pictureBoxGameField = new System.Windows.Forms.PictureBox();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonCredits);
            this.panelMenu.Controls.Add(this.buttonHowToPlay);
            this.panelMenu.Controls.Add(this.buttonStart);
            this.panelMenu.Location = new System.Drawing.Point(68, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(870, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(346, 441);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 52);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.Location = new System.Drawing.Point(346, 371);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(163, 52);
            this.buttonCredits.TabIndex = 2;
            this.buttonCredits.Text = "Twórcy";
            this.buttonCredits.UseVisualStyleBackColor = true;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.Location = new System.Drawing.Point(346, 301);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(163, 52);
            this.buttonHowToPlay.TabIndex = 1;
            this.buttonHowToPlay.Text = "Instrukcja gry";
            this.buttonHowToPlay.UseVisualStyleBackColor = true;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(346, 231);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(163, 52);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Graj";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.labelGameOverText);
            this.panelGame.Controls.Add(this.labelScore);
            this.panelGame.Controls.Add(this.labelScoreString);
            this.panelGame.Controls.Add(this.pictureBoxGameField);
            this.panelGame.Controls.Add(this.buttonBackToMenu);
            this.panelGame.Location = new System.Drawing.Point(68, 12);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(870, 700);
            this.panelGame.TabIndex = 4;
            // 
            // labelGameOverText
            // 
            this.labelGameOverText.AutoSize = true;
            this.labelGameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameOverText.Location = new System.Drawing.Point(53, 177);
            this.labelGameOverText.Name = "labelGameOverText";
            this.labelGameOverText.Size = new System.Drawing.Size(95, 36);
            this.labelGameOverText.TabIndex = 4;
            this.labelGameOverText.Text = "label2";
            this.labelGameOverText.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.Location = new System.Drawing.Point(714, 45);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(85, 21);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "label1";
            // 
            // labelScoreString
            // 
            this.labelScoreString.AutoSize = true;
            this.labelScoreString.Font = new System.Drawing.Font("BankGothic Lt BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreString.Location = new System.Drawing.Point(695, 15);
            this.labelScoreString.Name = "labelScoreString";
            this.labelScoreString.Size = new System.Drawing.Size(120, 30);
            this.labelScoreString.TabIndex = 2;
            this.labelScoreString.Text = "Punkty";
            // 
            // pictureBoxGameField
            // 
            this.pictureBoxGameField.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBoxGameField.Location = new System.Drawing.Point(18, 15);
            this.pictureBoxGameField.Name = "pictureBoxGameField";
            this.pictureBoxGameField.Size = new System.Drawing.Size(620, 650);
            this.pictureBoxGameField.TabIndex = 1;
            this.pictureBoxGameField.TabStop = false;
            this.pictureBoxGameField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGameField_Paint);
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(728, 662);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(142, 35);
            this.buttonBackToMenu.TabIndex = 0;
            this.buttonBackToMenu.Text = "Powrót do menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // formSnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSnakeGame";
            this.Text = "Projekt: Snake";
            this.Load += new System.EventHandler(this.formSnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formSnakeGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.formSnakeGame_KeyUp);
            this.panelMenu.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Button buttonHowToPlay;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreString;
        private System.Windows.Forms.PictureBox pictureBoxGameField;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelGameOverText;
    }
}