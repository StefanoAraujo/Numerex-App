using Android.Widget;
using System;

namespace Numerex.Core
{
    public class Game_Core
    {
        Random gerador_numeros = new Random();
        int[,] sequencia_numeros = new int[7, 10];

        public int[,] preenche_Matriz()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sequencia_numeros[i, j] = gerador_numeros.Next(0, 9);
                }
            }
            return sequencia_numeros;
        }

        public void escreve_Matriz(int[,] matriz)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("|" + matriz[i, j] + "|");
                }
            }
        }

        public int preenche_Botoes(int linha, int coluna)
        {
            return sequencia_numeros[linha, coluna];
        }

        public int gerador_Posicao_Linha()
        {
            return gerador_numeros.Next(0, 7);
        }

        public int gerador_Posicao_Coluna()
        {
            return gerador_numeros.Next(0, 9);
        }
    }
}