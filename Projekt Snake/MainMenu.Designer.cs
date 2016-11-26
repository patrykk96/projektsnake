namespace Projekt_Snake
{
    partial class formMenu
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.buttonCreators = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(86, 60);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(120, 30);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Graj";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.Location = new System.Drawing.Point(86, 96);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(120, 30);
            this.buttonHowToPlay.TabIndex = 1;
            this.buttonHowToPlay.Text = "Instrukcja gry";
            this.buttonHowToPlay.UseVisualStyleBackColor = true;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // buttonCreators
            // 
            this.buttonCreators.Location = new System.Drawing.Point(86, 132);
            this.buttonCreators.Name = "buttonCreators";
            this.buttonCreators.Size = new System.Drawing.Size(120, 30);
            this.buttonCreators.TabIndex = 2;
            this.buttonCreators.Text = "Twórcy";
            this.buttonCreators.UseVisualStyleBackColor = true;
            this.buttonCreators.Click += new System.EventHandler(this.buttonCreators_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(86, 168);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 30);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCreators);
            this.Controls.Add(this.buttonHowToPlay);
            this.Controls.Add(this.buttonPlay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMenu";
            this.Text = "Snake";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonHowToPlay;
        private System.Windows.Forms.Button buttonCreators;
        private System.Windows.Forms.Button buttonExit;
    }
}

