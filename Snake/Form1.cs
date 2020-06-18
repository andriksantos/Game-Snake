using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Código hecho por Héctor de león
/// www.hdeleon.net
/// </summary>
namespace Snake
{
    public partial class Form1 : Form
    {
        Game oGame;
        public Form1()
        {
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            oGame = new Game(pictureBox1, labelPoints);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!oGame.IsLost)
            {
                oGame.Next();
                oGame.Show();
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Game Over");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                oGame.ActualDirection = Game.Direction.Up;
            if (e.KeyCode == Keys.D)
                oGame.ActualDirection = Game.Direction.Right;
            if (e.KeyCode == Keys.A)
                oGame.ActualDirection = Game.Direction.Left;
            if (e.KeyCode == Keys.S)
                oGame.ActualDirection = Game.Direction.Down;
        }
    }
}
