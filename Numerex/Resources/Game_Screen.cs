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

namespace Numerex.Resources
{
    [Activity(Theme = "@style/MeuTema", Label = "Numerex")]
    public class Game_Screen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Game_Screen);
            // Create your application here

            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.SetBackgroundDrawable(new ColorDrawable(Color.Red));

            //string color = "#15a769";
            //Window.SetStatusBarColor(Android.Graphics.Color.ParseColor(color));

            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Lollipop)
            {
                //string color = "#15a769";
                Window.SetStatusBarColor(Android.Graphics.Color.Red);
            }
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