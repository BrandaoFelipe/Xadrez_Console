using System;
using tabuleiro;
using xadrez;



internal class Program
{
    private static void Main(string[] args)
    {     
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tab);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                bool[,] PosicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();

                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tab, PosicoesPossiveis);

                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                partida.ExecutarMovimento(origem, destino);
            }



            
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine("Error in Tabuleiro! " + e.Message);
        }






    }
}