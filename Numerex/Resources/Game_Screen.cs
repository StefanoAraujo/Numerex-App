using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;
using Android.Graphics;
using Numerex.Core;

namespace Numerex.Resources
{
    [Activity(Label = "Numerex")]
    public class Game_Screen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Game_Screen);
            // Create your application here

            //teste
            Button[,] btne = new Button[7, 10];

            Game_Core escreve = new Game_Core();
            escreve.escreve_Matriz(escreve.preenche_Matriz());

            btne[0, 0] = FindViewById<Button>(Resource.Id.btn_0x0);
            btne[0, 1] = FindViewById<Button>(Resource.Id.btn_0x1);
            btne[0, 2] = FindViewById<Button>(Resource.Id.btn_0x2);
            btne[0, 3] = FindViewById<Button>(Resource.Id.btn_0x3);
            btne[0, 4] = FindViewById<Button>(Resource.Id.btn_0x4);
            btne[0, 5] = FindViewById<Button>(Resource.Id.btn_0x5);
            btne[0, 6] = FindViewById<Button>(Resource.Id.btn_0x6);
            btne[0, 7] = FindViewById<Button>(Resource.Id.btn_0x7);
            btne[0, 8] = FindViewById<Button>(Resource.Id.btn_0x8);
            btne[0, 9] = FindViewById<Button>(Resource.Id.btn_0x9);
            btne[1, 0] = FindViewById<Button>(Resource.Id.btn_1x0);
            btne[1, 1] = FindViewById<Button>(Resource.Id.btn_1x1);
            btne[1, 2] = FindViewById<Button>(Resource.Id.btn_1x2);
            btne[1, 3] = FindViewById<Button>(Resource.Id.btn_1x3);
            btne[1, 4] = FindViewById<Button>(Resource.Id.btn_1x4);
            btne[1, 5] = FindViewById<Button>(Resource.Id.btn_1x5);
            btne[1, 6] = FindViewById<Button>(Resource.Id.btn_1x6);
            btne[1, 7] = FindViewById<Button>(Resource.Id.btn_1x7);
            btne[1, 8] = FindViewById<Button>(Resource.Id.btn_1x8);
            btne[1, 9] = FindViewById<Button>(Resource.Id.btn_1x9);
            btne[2, 0] = FindViewById<Button>(Resource.Id.btn_2x0);
            btne[2, 1] = FindViewById<Button>(Resource.Id.btn_2x1);
            btne[2, 2] = FindViewById<Button>(Resource.Id.btn_2x2);
            btne[2, 3] = FindViewById<Button>(Resource.Id.btn_2x3);
            btne[2, 4] = FindViewById<Button>(Resource.Id.btn_2x4);
            btne[2, 5] = FindViewById<Button>(Resource.Id.btn_2x5);
            btne[2, 6] = FindViewById<Button>(Resource.Id.btn_2x6);
            btne[2, 7] = FindViewById<Button>(Resource.Id.btn_2x7);
            btne[2, 8] = FindViewById<Button>(Resource.Id.btn_2x8);
            btne[2, 9] = FindViewById<Button>(Resource.Id.btn_2x9);
            btne[3, 0] = FindViewById<Button>(Resource.Id.btn_3x0);
            btne[3, 1] = FindViewById<Button>(Resource.Id.btn_3x1);
            btne[3, 2] = FindViewById<Button>(Resource.Id.btn_3x2);
            btne[3, 3] = FindViewById<Button>(Resource.Id.btn_3x3);
            btne[3, 4] = FindViewById<Button>(Resource.Id.btn_3x4);
            btne[3, 5] = FindViewById<Button>(Resource.Id.btn_3x5);
            btne[3, 6] = FindViewById<Button>(Resource.Id.btn_3x6);
            btne[3, 7] = FindViewById<Button>(Resource.Id.btn_3x7);
            btne[3, 8] = FindViewById<Button>(Resource.Id.btn_3x8);
            btne[3, 9] = FindViewById<Button>(Resource.Id.btn_3x9);
            btne[4, 0] = FindViewById<Button>(Resource.Id.btn_4x0);
            btne[4, 1] = FindViewById<Button>(Resource.Id.btn_4x1);
            btne[4, 2] = FindViewById<Button>(Resource.Id.btn_4x2);
            btne[4, 3] = FindViewById<Button>(Resource.Id.btn_4x3);
            btne[4, 4] = FindViewById<Button>(Resource.Id.btn_4x4);
            btne[4, 5] = FindViewById<Button>(Resource.Id.btn_4x5);
            btne[4, 6] = FindViewById<Button>(Resource.Id.btn_4x6);
            btne[4, 7] = FindViewById<Button>(Resource.Id.btn_4x7);
            btne[4, 8] = FindViewById<Button>(Resource.Id.btn_4x8);
            btne[4, 9] = FindViewById<Button>(Resource.Id.btn_4x9);
            btne[5, 0] = FindViewById<Button>(Resource.Id.btn_5x0);
            btne[5, 1] = FindViewById<Button>(Resource.Id.btn_5x1);
            btne[5, 2] = FindViewById<Button>(Resource.Id.btn_5x2);
            btne[5, 3] = FindViewById<Button>(Resource.Id.btn_5x3);
            btne[5, 4] = FindViewById<Button>(Resource.Id.btn_5x4);
            btne[5, 5] = FindViewById<Button>(Resource.Id.btn_5x5);
            btne[5, 6] = FindViewById<Button>(Resource.Id.btn_5x6);
            btne[5, 7] = FindViewById<Button>(Resource.Id.btn_5x7);
            btne[5, 8] = FindViewById<Button>(Resource.Id.btn_5x8);
            btne[5, 9] = FindViewById<Button>(Resource.Id.btn_5x9);
            btne[6, 0] = FindViewById<Button>(Resource.Id.btn_6x0);
            btne[6, 1] = FindViewById<Button>(Resource.Id.btn_6x1);
            btne[6, 2] = FindViewById<Button>(Resource.Id.btn_6x2);
            btne[6, 3] = FindViewById<Button>(Resource.Id.btn_6x3);
            btne[6, 4] = FindViewById<Button>(Resource.Id.btn_6x4);
            btne[6, 5] = FindViewById<Button>(Resource.Id.btn_6x5);
            btne[6, 6] = FindViewById<Button>(Resource.Id.btn_6x6);
            btne[6, 7] = FindViewById<Button>(Resource.Id.btn_6x7);
            btne[6, 8] = FindViewById<Button>(Resource.Id.btn_6x8);
            btne[6, 9] = FindViewById<Button>(Resource.Id.btn_6x9);

            int[,] resultado_Sorteio = new int[7, 10];


            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    resultado_Sorteio[i, j] = escreve.preenche_Botoes(i, j);
                }
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    btne[i, j].Text = resultado_Sorteio[i, j].ToString();
                }
            }

            int position_X = 0, position_Y = 0;

            int[,] resultado = new int[10, 4];

            position_X = escreve.gerador_Posicao_Linha();
            position_Y = escreve.gerador_Posicao_Coluna();

            TextView base_0x0 = FindViewById<TextView>(Resource.Id.base_0x0);
            TextView base_0x1 = FindViewById<TextView>(Resource.Id.base_0x1);
            TextView base_0x2 = FindViewById<TextView>(Resource.Id.base_0x2);
            TextView base_0x3 = FindViewById<TextView>(Resource.Id.base_0x3);
            TextView base_0x4 = FindViewById<TextView>(Resource.Id.base_0x4);
            TextView base_1x0 = FindViewById<TextView>(Resource.Id.base_1x0);
            TextView base_1x1 = FindViewById<TextView>(Resource.Id.base_1x1);
            Console.WriteLine("X = " + position_X + "|" + "Y = " + position_Y);

            Random aleatorio = new Random();

            if (position_X == 0)
            {
                Console.WriteLine("Igual Lin");
                position_X = aleatorio.Next(1, 3) + position_X;
                resultado[0, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[0, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[0, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[0, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[1, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[1, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[1, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[1, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[2, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[2, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[2, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[2, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[3, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[3, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[3, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[3, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[4, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[4, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[4, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[4, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[5, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[5, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[5, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[5, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[6, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[6, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[6, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                resultado[6, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
            }
            else
            {
                if (position_Y == 0)
                {
                    Console.WriteLine("Igual Lin");
                    position_Y = aleatorio.Next(1, 3) + position_Y;
                    resultado[0, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[0, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[0, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[0, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[1, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[1, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[1, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[1, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[2, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[2, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[2, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[2, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[3, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[3, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[3, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[3, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[4, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[4, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[4, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[4, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[5, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[5, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[5, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[5, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[6, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[6, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[6, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    resultado[6, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                }
                else
                {
                    if (position_X == 6)
                    {
                        Console.WriteLine("Igual Col");
                        position_X = position_X - aleatorio.Next(1, 3);
                        resultado[0, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[0, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[0, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[0, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[1, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[1, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[1, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[1, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[2, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[2, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[2, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[2, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[3, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[3, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[3, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[3, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[4, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[4, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[4, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[4, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[5, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[5, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[5, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[5, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[6, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[6, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[6, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        resultado[6, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                    }
                    else
                    {
                        if (position_Y == 9)
                        {
                            Console.WriteLine("Igual Col");
                            position_Y = position_Y - aleatorio.Next(1, 3);
                            resultado[0, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[0, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[0, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[0, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[1, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[1, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[1, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[1, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[2, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[2, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[2, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[2, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[3, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[3, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[3, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[3, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[4, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[4, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[4, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[4, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[5, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[5, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[5, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[5, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[6, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[6, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[6, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            resultado[6, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                        }
                        else
                        {
                            if (position_X != 0 && position_X != 6 && position_Y != 0 && position_Y != 9)
                            {
                                Console.WriteLine("Diferente");
                                resultado[0, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[0, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[0, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[0, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[1, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[1, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[1, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[1, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[2, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[2, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[2, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[2, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[3, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[3, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[3, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[3, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[4, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[4, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[4, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[4, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[5, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[5, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[5, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[5, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[6, 0] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[6, 1] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[6, 2] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                                resultado[6, 3] = resultado_Sorteio[position_X + aleatorio.Next(-1, 1), position_Y + aleatorio.Next(-1, 1)];
                            }
                        }
                    }
                }
            }
            base_0x0.Text = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
            base_0x1.Text = resultado[1, 0].ToString() + resultado[1, 1].ToString() + resultado[1, 2].ToString() + resultado[1, 3].ToString();
            base_0x2.Text = resultado[2, 0].ToString() + resultado[2, 1].ToString() + resultado[2, 2].ToString() + resultado[2, 3].ToString();
            base_0x3.Text = resultado[3, 0].ToString() + resultado[3, 1].ToString() + resultado[3, 2].ToString() + resultado[3, 3].ToString();
            base_0x4.Text = resultado[4, 0].ToString() + resultado[4, 1].ToString() + resultado[4, 2].ToString() + resultado[4, 3].ToString();
            base_1x0.Text = resultado[5, 0].ToString() + resultado[5, 1].ToString() + resultado[5, 2].ToString() + resultado[5, 3].ToString();
            base_1x1.Text = resultado[6, 0].ToString() + resultado[6, 1].ToString() + resultado[6, 2].ToString() + resultado[6, 3].ToString();

            string ass = "";

            btne[0, 0].Click += (sender, e) =>{
                ass = resultado_Sorteio[0, 0].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 1].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 1].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 2].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 2].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 3].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 3].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 4].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 4].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 5].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 5].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 6].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 6].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 7].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 7].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 8].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 8].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[0, 9].Click += (sender, e) => {
                ass = resultado_Sorteio[0, 9].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                string oioi = resultado[0, 0].ToString() + resultado[0, 1].ToString() + resultado[0, 2].ToString() + resultado[0, 3].ToString();
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 0].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 0].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 1].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 1].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 2].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 2].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 3].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 3].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 4].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 4].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 5].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 5].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 6].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 6].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 7].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 7].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 8].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 8].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[1, 9].Click += (sender, e) => {
                ass = resultado_Sorteio[1, 9].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 0].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 0].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 1].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 1].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 2].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 2].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 3].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 3].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 4].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 4].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 5].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 5].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 6].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 6].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 7].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 7].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 8].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 8].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[2, 9].Click += (sender, e) => {
                ass = resultado_Sorteio[2, 9].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 0].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 0].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 1].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 1].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 2].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 2].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 3].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 3].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 4].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 4].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 5].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 5].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 6].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 6].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 7].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 7].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 8].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 8].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[3, 9].Click += (sender, e) => {
                ass = resultado_Sorteio[3, 9].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 0].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 0].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 1].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 1].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 2].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 2].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 3].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 3].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 4].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 4].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 5].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 5].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 6].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 6].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 7].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 7].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 8].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 8].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[4, 9].Click += (sender, e) => {
                ass = resultado_Sorteio[4, 9].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 0].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 0].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 1].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 1].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 2].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 2].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 3].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 3].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 4].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 4].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 5].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 5].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 6].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 6].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 7].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 7].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 8].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 8].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[5, 9].Click += (sender, e) => {
                ass = resultado_Sorteio[5, 9].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 0].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 0].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 1].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 1].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 2].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 2].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 3].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 3].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 4].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 4].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 5].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 5].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 6].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 6].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 7].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 7].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 8].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 8].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            btne[6, 9].Click += (sender, e) => {
                ass = resultado_Sorteio[6, 9].ToString() + ass;
                Console.WriteLine("Aqui é o resultado do click " + ass);
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x1.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x2.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x3.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_0x4.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x0.Visibility = ViewStates.Gone;
                    }
                }
                if (ass != "")
                {
                    if (ass == oioi)
                    {
                        base_1x1.Visibility = ViewStates.Gone;
                    }
                }
            };
            //fim teste

            string color = "#15a769";
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor(color)));
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}