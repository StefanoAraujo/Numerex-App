using Android.App;
using Android.Widget;
using Android.OS;
using Numerex.Resources;

namespace Numerex
{
    [Activity(Label = "Numerex", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            Button btn_Jogar = FindViewById<Button>(Resource.Id.Button_Play);
            Button btn_Ajuda = FindViewById<Button>(Resource.Id.Button_Ajuda);
            Button btn_Opcoes = FindViewById<Button>(Resource.Id.Button_Opcoes);

            btn_Jogar.Click += Btn_Jogar_Click;
        }

        private void Btn_Jogar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Carregar_Jogo();
            }
            catch (System.Exception erro_Activity)
            {
                Toast.MakeText(this, erro_Activity.Message, ToastLength.Long).Show();
            }
        }

        protected void Carregar_Jogo()
        {
            Android.Content.Intent obj_Jogo = new Android.Content.Intent(this, typeof(Game_Screen));
            StartActivity(obj_Jogo);
        }
    }
}

