namespace Projekt_Snake
{
    partial class GameWindow
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
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(13, 13);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(117, 23);
            this.buttonBackToMenu.TabIndex = 0;
            this.buttonBackToMenu.Text = "Wróć do Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 393);
            this.Controls.Add(this.buttonBackToMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.Text = "Snake";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMenu;
    }
}