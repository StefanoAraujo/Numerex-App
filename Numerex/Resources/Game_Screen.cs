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
            Game_Core escreve = new Game_Core();
            escreve.escreve_Matriz(escreve.preenche_Matriz());
            //fim teste

            string color = "#15a769";
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor(color)));
            //Window.SetStatusBarColor(Android.Graphics.Color.ParseColor(color));

            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Lollipop)
            {
                //string color = "#15a769";
                Window.SetStatusBarColor(Android.Graphics.Color.Red);
            }

            //Program core
            Random gerador = new Random();
            Button[,] btne = new Button[7, 10];
            int[] valor_0 = new int[5], valor_1 = new int[5], valor_2 = new int[5], valor_3 = new int[5], valor_4 = new int[5], valor_5 = new int[5], valor_6 = new int[5], valor_7 = new int[5], valor_8 = new int[5], valor_9 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                valor_0[i] = gerador.Next(0, 9);
                valor_1[i] = gerador.Next(0, 9);
                valor_2[i] = gerador.Next(0, 9);
                valor_3[i] = gerador.Next(0, 9);
                valor_4[i] = gerador.Next(0, 9);
                valor_5[i] = gerador.Next(0, 9);
                valor_6[i] = gerador.Next(0, 9);
                valor_7[i] = gerador.Next(0, 9);
                valor_8[i] = gerador.Next(0, 9);
                valor_9[i] = gerador.Next(0, 9);
            }

            string resultado_0 = "", resultado_1 = "", resultado_2 = "", resultado_3 = "", resultado_4 = "", resultado_5 = "", resultado_6 = "", resultado_7 = "", resultado_8 = "", resultado_9 = "";

            for (int i = 0; i < 5; i++)
            {
                resultado_0 = valor_0[i].ToString() + resultado_0;
                resultado_1 = valor_1[i].ToString() + resultado_1;
                resultado_2 = valor_2[i].ToString() + resultado_2;
                resultado_3 = valor_3[i].ToString() + resultado_3;
                resultado_4 = valor_4[i].ToString() + resultado_4;
                resultado_5 = valor_5[i].ToString() + resultado_5;
                resultado_6 = valor_6[i].ToString() + resultado_6;
                resultado_7 = valor_7[i].ToString() + resultado_7;
                resultado_8 = valor_8[i].ToString() + resultado_8;
                resultado_9 = valor_9[i].ToString() + resultado_9;
            }

            //TextView
            TextView base_0x0 = FindViewById<TextView>(Resource.Id.base_0x0);
            TextView base_0x1 = FindViewById<TextView>(Resource.Id.base_0x1);
            TextView base_0x2 = FindViewById<TextView>(Resource.Id.base_0x2);
            TextView base_0x3 = FindViewById<TextView>(Resource.Id.base_0x3);
            TextView base_0x4 = FindViewById<TextView>(Resource.Id.base_0x4);
            TextView base_1x0 = FindViewById<TextView>(Resource.Id.base_1x0);
            TextView base_1x1 = FindViewById<TextView>(Resource.Id.base_1x1);
            TextView base_1x2 = FindViewById<TextView>(Resource.Id.base_1x2);
            TextView base_1x3 = FindViewById<TextView>(Resource.Id.base_1x3);
            TextView base_1x4 = FindViewById<TextView>(Resource.Id.base_1x4);

            base_0x0.Text = resultado_0.ToString();
            base_0x1.Text = resultado_1.ToString();
            base_0x2.Text = resultado_2.ToString();
            base_0x3.Text = resultado_3.ToString();
            base_0x4.Text = resultado_4.ToString();
            base_1x0.Text = resultado_5.ToString();
            base_1x1.Text = resultado_6.ToString();
            base_1x2.Text = resultado_7.ToString();
            base_1x3.Text = resultado_8.ToString();
            base_1x4.Text = resultado_9.ToString();

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

            int a_0 = 0, a_1 = 0, a_2 = 0, a_3 = 0, a_4 = 0, a_5 = 0, a_6 = 0, a_7 = 0, a_8 = 0;
            int b_0 = 0, b_1 = 0, b_2 = 0, b_3 = 0, b_4 = 0, b_5 = 0, b_6 = 0, b_7 = 0, b_8 = 0;
            a_0 = gerador.Next(0, 6);
            b_0 = gerador.Next(5, 10);
            btne[a_0, b_0].Text = valor_0[0].ToString();
            btne[a_0, b_0 - 1].Text = valor_0[1].ToString();
            btne[a_0, b_0 - 2].Text = valor_0[2].ToString();
            btne[a_0, b_0 - 3].Text = valor_0[3].ToString();
            btne[a_0, b_0 - 4].Text = valor_0[4].ToString();
            a_1 = gerador.Next(0, 6);
            b_1 = gerador.Next(5, 10);
            btne[a_1, b_1].Text = valor_1[0].ToString();
            btne[a_1, b_1 - 1].Text = valor_1[1].ToString();
            btne[a_1, b_1 - 2].Text = valor_1[2].ToString();
            btne[a_1, b_1 - 3].Text = valor_1[3].ToString();
            btne[a_1, b_1 - 4].Text = valor_1[4].ToString();
            a_2 = gerador.Next(0, 6);
            b_2 = gerador.Next(5, 10);
            btne[a_2, b_2].Text = valor_2[0].ToString();
            btne[a_2, b_2 - 1].Text = valor_2[1].ToString();
            btne[a_2, b_2 - 2].Text = valor_2[2].ToString();
            btne[a_2, b_2 - 3].Text = valor_2[3].ToString();
            btne[a_2, b_2 - 4].Text = valor_2[4].ToString();
            a_3 = gerador.Next(0, 6);
            btne[a_3, 0].Text = valor_4[0].ToString();
            btne[a_3, 1].Text = valor_4[1].ToString();
            btne[a_3, 2].Text = valor_4[2].ToString();
            btne[a_3, 3].Text = valor_4[3].ToString();
            btne[a_3, 4].Text = valor_4[4].ToString();
            a_4 = gerador.Next(0, 6);
            btne[a_4, 0].Text = valor_5[0].ToString();
            btne[a_4, 1].Text = valor_5[1].ToString();
            btne[a_4, 2].Text = valor_5[2].ToString();
            btne[a_4, 3].Text = valor_5[3].ToString();
            btne[a_4, 4].Text = valor_5[4].ToString();
            a_5 = gerador.Next(0, 6);
            btne[a_5, 0].Text = valor_6[0].ToString();
            btne[a_5, 1].Text = valor_6[1].ToString();
            btne[a_5, 2].Text = valor_6[2].ToString();
            btne[a_5, 3].Text = valor_6[3].ToString();
            btne[a_5, 4].Text = valor_6[4].ToString();
            a_6 = gerador.Next(0, 6);
            btne[a_6, 0].Text = valor_7[0].ToString();
            btne[a_6, 1].Text = valor_7[1].ToString();
            btne[a_6, 2].Text = valor_7[2].ToString();
            btne[a_6, 3].Text = valor_7[3].ToString();
            btne[a_6, 4].Text = valor_7[4].ToString();
            a_7 = gerador.Next(0, 6);
            btne[a_7, 0].Text = valor_8[0].ToString();
            btne[a_7, 1].Text = valor_8[1].ToString();
            btne[a_7, 2].Text = valor_8[2].ToString();
            btne[a_7, 3].Text = valor_8[3].ToString();
            btne[a_7, 4].Text = valor_8[4].ToString();
            a_8 = gerador.Next(0, 6);
            btne[a_8, 0].Text = valor_9[0].ToString();
            btne[a_8, 1].Text = valor_9[1].ToString();
            btne[a_8, 2].Text = valor_9[2].ToString();
            btne[a_8, 3].Text = valor_9[3].ToString();
            btne[a_8, 4].Text = valor_9[4].ToString();

            btne[0, 0].Click += delegate
            {
                btne[0, 0].SetBackgroundColor(Color.Red);
            };
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