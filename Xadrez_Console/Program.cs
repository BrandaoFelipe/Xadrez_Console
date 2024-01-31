using System;
using tabuleiro;
using xadrez;


internal class Program
{
    private static void Main(string[] args)
    {
        // Posicao p = new Posicao(3, 4);
        //Console.WriteLine("Posição: " + p);
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);


            tab.ColocarPeca(new Torre(tab, Color.Black), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Color.Black), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Color.Black), new Posicao(0, 0));



            Tela.ImprimirTabuleiro(tab); //MÉTODO ESTÁTICO QUE SERVE PARA IMPRIMIR NA TELA,
                                         //O CW ESTÁ DENTRO DESSE MÉTODO, PORTANTO QUANDO
                                         //É INVOCADO, ELE RETORNA O CW.
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine("Error in Tabuleiro! " + e.Message);
        }






    }
}