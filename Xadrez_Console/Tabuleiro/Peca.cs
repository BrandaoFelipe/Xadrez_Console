

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Color Color { get; protected set; }
        public int QuantMovimento { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Color color, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Color = color;
            tab = tabuleiro;
            QuantMovimento = 0; 
        }
    }
}
