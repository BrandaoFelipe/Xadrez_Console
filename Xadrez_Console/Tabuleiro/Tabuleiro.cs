

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca [,] pecas  { get; set; } //PORQUE ESSA MATRIZ NÃO PODE SER ACESSADA DE FORA?
                                              //P/ NGM ALTERAR A MATRIZ

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }


        public Peca peca (int linha, int coluna) //ESSE MÉTODO NOS DEIXA (LER) ACESSAR A MATRIZ(TABULEIRO)
        {
            return pecas[linha, coluna];
        }
        public Peca peca (Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos) //ESSE MÉTODO ADICIONA UMA PEÇA NO TABULEIRO,
                                                     //OU NA MATRIZ PEÇA
        {
            if(ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[pos.Linha, pos.Coluna] = p; 
        }

        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if(!PosicaoValida(pos) == true)
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
