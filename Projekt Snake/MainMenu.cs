using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Snake
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poruszasz się za pomocą strzałek, zjadaj jedzenie aby wydłużać węża. Zderzenie się z własnym ogonem lub ze ścianą spowoduje koniec gry", "Instrukcja gry");
        }

        private void buttonCreators_Click(object sender, EventArgs e)
        {
            MessageBox.Show("P.K. i D. M." + "\n" + "2016", "Twórcy");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            GameWindow game = new GameWindow();
            this.Hide();
            game.Show();
        }
    }
}
