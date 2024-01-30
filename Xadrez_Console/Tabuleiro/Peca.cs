

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Color Color { get; protected set; }
        public int QuantMovimento { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tabuleiro, Color color)
        {
            Posicao = null;
            Color = color;
            tab = tabuleiro;
            QuantMovimento = 0; 
        }
    }
}
