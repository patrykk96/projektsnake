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
    public partial class formSnakeGame : Form
    {
        List<Panel> listPanel = new List<Panel>();
        
        public formSnakeGame()
        {
            InitializeComponent();
        }

        

        private void formSnakeGame_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelMenu);
            listPanel.Add(panelGame);
            listPanel[0].BringToFront();
            listPanel[1].SendToBack();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku start zmienia panel z menu na pole gry ichowa panel menu
            listPanel[1].BringToFront();
            listPanel[0].Visible = false;
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku wystawia panel menu do przodu
            listPanel[0].BringToFront();
            listPanel[1].SendToBack();
            listPanel[0].Visible = true;
        }

        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku wyskakuje komunikat
            MessageBox.Show("Do poruszania się używaj strzałek, zjadaj jedzenie aby rosnąć, zderzenie z własnym ogonem lub ścianą spowoduje koniec gry", "Instrukcja gry");
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            //po kliknięciu przycisku wyskakuje komunikat
            MessageBox.Show("P. K., D. M." + "\n" + "2016");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //kliknięcie przycisku zamyka program
            this.Close();
        }
    }
}
