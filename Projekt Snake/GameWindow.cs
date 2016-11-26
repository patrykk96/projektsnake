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
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            formMenu menu = new formMenu();
            this.Close();
            menu.Show();
        }
    }
}
