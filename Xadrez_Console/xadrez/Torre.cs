using tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Color cor) : base(tab, cor) { }


        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new(0, 0);
            
            //ACIMA
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos)) 
            {
                mat[pos.Linha, pos.Coluna]= true;
                if (tab.peca(pos) != null && tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //ABAIXO
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //ESQUERDA
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            //DIREITA
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            return mat;
        }
    }
}
