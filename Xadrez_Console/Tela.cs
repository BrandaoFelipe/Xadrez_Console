using tabuleiro;
using System;

namespace xadrez
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab) //MÉTODO STATIC NÃO RETORNA VALOR, E NÃO DEPENDE DE VALORES,
                                                            //EXEMPLO CALCULADORA QUE NÃO PRECISA DE ENTRADA DE DADOS,
                                                            //TODO O MÉTODO APLICADO AQUI SERVE PARA LER A MATRIZ E
                                                            //IMPRIMIR NO CONSOLE COM O FORMATO ESTABELECIDO.
                                                            //A MATRIZ (PECA[,]) FOI POSTA COMO PRIVATE PARA NÃO SER ACESSADA.
                                                            //A FORMA DE ACESSAR OS DADOS É ATRAVÉS DE UM
                                                            //MÉTODO DENTRO DA PRÓPRIA CLASSE.
        {

            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null) //AQUI NESSA ESTRUTURA CONDICIONAL ESTÁ O MÉTODO (TAB.PECA) QUE ACESSA A MATRIZ).
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " "); 
                    } 
                }
                Console.WriteLine();
            }



        }
    }
}
