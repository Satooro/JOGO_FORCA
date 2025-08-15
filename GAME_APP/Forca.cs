using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_APP
{
    public class Forca
    {
        public List<string> Palavras {  get; set; }
        public List<string> Dicas {  get; set; }
        public int Pos { get; set; }

        public Forca(List<string> Palavras, List<string> dicas)
        {
            this.Palavras = Palavras;
            Dicas = dicas;
        }
        public void Sortear()
        {
            Random random = new Random();
            Pos = random.Next(Palavras.Count());
        }
    }
}
