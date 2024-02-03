

namespace tabuleiro
{
    internal class Peca // É A CLASSE GENÉRICA DAS PEÇAS,
                        // AS PEÇAS (SUBCLASSES) USARÃO OS ATRIBUTOS DESSA CLASSE
                        // COMO HERANÇA
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

        public void IncrementarMovimento()
        {
            QuantMovimento++;
        }
    }
}
