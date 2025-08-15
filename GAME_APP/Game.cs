using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_APP
{
    public partial class Game : Form
    {

        Forca jogo;
        Label[] Letras;

        public readonly List<string> Palavras = new List<string>()
        {
            "PNEUMOULTRAMICROSCOPICOSSILICOVULCANOCONIOSE", "HEMORROIDA", "TESTOSTERONA", "ITAPEVA", "JACARE", "CROCODILO", 
            "COBRA", "CANGURU", "CACHORRO", "RUSSIA", "JAPONESINHA", "LIMONADA", "MAGRINHO", "BANANA", "BISTECA", "PIMBADA", 
            "SIRENA", "PNEU", "JOGATINA", "VULCAO"
        };

        public readonly List<string> Dicas = new List<string>()
        {
            "MAIOR PALAVRA", "NO BUMBUM", "USAM PRA TREINAR", "CIDADE", "RÉPTIL DO BRASIL", "RÉPTIL DOS EUA",
            "SNAKE IN THE GRASS", "TEM NA AUSTRALIA", "CHINES COME", "BANIU OS LGBT", "TEVE 2 NAMORADOS", "TIPO DE SUCO", "PUXEI O ** DELE",
            "ASSOMBRA A NAMORADA", "CARNE", "TODO MUNDO GOSTA", "TEM NA AMBULÂNCIA", "TEM NO CARRO", "ADOLESCENCIA", "SE ESTRESSA E EXPLODE"
        };

        public Game()
        {
            InitializeComponent();
        }

        private void TXTLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) || char.is)
            //{
            //    e.Handled = true;
            //}
        }

        private void Game_Load(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void NovoJogo()
        {
            jogo = new Forca(Palavras, Dicas);
            jogo.Sortear();
            LBDica.Text = $"Dica: {jogo.Dicas[jogo.Pos]}";
            DesenharPalavra(jogo.Palavras[jogo.Pos]);
        }

        private void DesenharPalavra(string v)
        {
            Letras = new Label[v.Length];
            PNPalavra.Controls.Clear();
            int x = 10, y = 10;
            for (int i = 0; i < v.Length; i++)
            {
                Letras[i] = new Label();
                Letras[i].Text = "?";
                Letras[i].Width = 50;
                Letras[i].Height = Letras[i].Width;
                Letras[i].ForeColor = Color.White;
                Letras[i].BackColor = Color.Azure;
                Letras[i].AutoSize = false;
                Letras[i].TextAlign = ContentAlignment.MiddleCenter;
                Letras[i].BorderStyle = BorderStyle.FixedSingle;
                if(i % 8 == 0 && i != 0)
                {
                    y += 50;
                    x = 10;
                }
                Letras[i].Left = x;
                Letras[i].Top = y;
                x += 55;
                PNPalavra.Controls.Add(Letras[i]);
                Letras[i].Show();
            }
        }

        private void BTNJogar_Click(object sender, EventArgs e)
        {
            string letra = TXTLetra.Text.ToUpper();
            DesenharLetra(letra);
            TXTLetra.Clear();
            TXTLetra.Focus();
        }

        private void DesenharLetra(string letra)
        {
            string palavra = jogo.Palavras[jogo.Pos];
            for (int i = 0; i < letra.Length; i++)
            {
                if (palavra.Substring(i,1) == letra)
                {
                    Letras[i].Text = letra;
                }
            }
        }
    }
}
