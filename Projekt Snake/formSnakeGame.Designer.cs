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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.Panel();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonCredits);
            this.panelMenu.Controls.Add(this.buttonHowToPlay);
            this.panelMenu.Controls.Add(this.buttonStart);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(529, 477);
            this.panelMenu.TabIndex = 0;
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.buttonBackToMenu);
            this.panelGame.Controls.Add(this.panelMenu);
            this.panelGame.Location = new System.Drawing.Point(116, 12);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(529, 477);
            this.panelGame.TabIndex = 4;
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(367, 13);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(142, 23);
            this.buttonBackToMenu.TabIndex = 0;
            this.buttonBackToMenu.Text = "Powrót do menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(177, 279);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 52);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.Location = new System.Drawing.Point(177, 221);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(163, 52);
            this.buttonCredits.TabIndex = 2;
            this.buttonCredits.Text = "Twórcy";
            this.buttonCredits.UseVisualStyleBackColor = true;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.Location = new System.Drawing.Point(177, 163);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(163, 52);
            this.buttonHowToPlay.TabIndex = 1;
            this.buttonHowToPlay.Text = "Instrukcja gry";
            this.buttonHowToPlay.UseVisualStyleBackColor = true;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(177, 105);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(163, 52);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Graj";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // formSnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panelGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSnakeGame";
            this.Text = "Projekt: Snake";
            this.Load += new System.EventHandler(this.formSnakeGame_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
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
    }
}