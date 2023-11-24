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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public Panel gamePanel
        {
            get { return rndPanel1; }
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            
            
            Hint hint = new Hint();
            hint.TopLevel = false;
            Form1 main = this.Parent.Parent as Form1;
            main.panel2Control.Controls.Clear();
            main.panel2Control.Controls.Add(hint);
            hint.BringToFront();
            hint.Show();


        }

        private void ButtonE_Click(object sender, EventArgs e)
        {
            Answer ans = new Answer();
            ans.TopLevel = false;

            Form1 main = this.Parent.Parent as Form1;
            main.panel2Control.Controls.Clear();
            main.panel2Control.Controls.Add(ans);

            ans.BringToFront();
            ans.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void rndPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
