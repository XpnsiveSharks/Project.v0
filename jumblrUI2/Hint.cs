using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jumblrUI2
{
    public partial class Hint : Form
    {
        public Hint()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 main = this.Parent.Parent as Form1;

            if (main != null)
            {
                Game game = new Game();
                game.TopLevel = false;

                main.panel2Control.Controls.Clear();
                main.panel2Control.Controls.Add(game);
                game.BringToFront();
                game.Show();
            }
        }

        private void rndPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hint_Load(object sender, EventArgs e)
        {

        }
    }
}
