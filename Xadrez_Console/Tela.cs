using tabuleiro;
using System;
using System.Security.Cryptography.X509Certificates;

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
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null) //AQUI NESSA ESTRUTURA CONDICIONAL ESTÁ O MÉTODO (TAB.PECA) QUE ACESSA A MATRIZ).
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Color == Color.White)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }

}
