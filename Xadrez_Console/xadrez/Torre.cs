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
    }
}
