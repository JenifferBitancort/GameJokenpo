using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Game_Jokenpo
{
    public class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }


        //Array de imagens
        public static Image[] imagens =
        {
            Image.FromFile("Imagens/ped.png"),
            Image.FromFile("Imagens/pap.png"),
            Image.FromFile("Imagens/tes.png")

        };

        //Imagem que o PC escolher
        public Image imgPC { get; private set; }

        //Imagem que o jogador escolher
        public Image imgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();

            imgJogador = imagens[jogador];
            imgPC = imagens[pc];

            //Definição do resultado
            if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0) && (pc == 1) || (jogador == 1) && (pc == 2))
            {
                return Resultado.Perder;
            }
            else
            {
                return Resultado.Ganhar;
            }
        }


        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            //retorna uma escolha para o PC
            if (mil < 333)
            {
                return 0;
            }
            else if (mil <= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

    }
}
