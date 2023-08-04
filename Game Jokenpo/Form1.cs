using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20___Game_Jokenpo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPedra_Click(object sender, EventArgs e)
        {
            Startgame(0);
        }

        private void buttonpapel_Click(object sender, EventArgs e)
        {
            Startgame(1);
        }

        private void buttonTesoura_Click(object sender, EventArgs e)
        {
            Startgame(2);
        }


        private void Startgame(int opção)
        {
            labelResultado.Visible = false;

            Game g = new Game();

            switch (g.Jogar(opção))
            {
                case Game.Resultado.Ganhar:
                    picresultado.BackgroundImage = Image.FromFile("Imagens/Ganhou.jpg");
                    goto default;
                case Game.Resultado.Perder:
                    picresultado.BackgroundImage = Image.FromFile("Imagens/Perdeu.jpg");
                    goto default;
                case Game.Resultado.Empatar:
                    picresultado.BackgroundImage = Image.FromFile("Imagens/empate.jpeg");
                    goto default;
                default:
                    pictureBox1.Image = g.imgJogador;
                    pictureBox2.Image = g.imgPC;
                    break;



            }

        }


    }
}
