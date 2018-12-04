using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Learning
{
    [Activity(Label = "Xamarin", Theme = "@style/splashTheme", MainLauncher = true, NoHistory = true)]
    public class splash : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here.
        }
        public override void OnBackPressed()
        {

        }

        protected override void OnResume()
        {
            base.OnResume();
            Task tk = new Task(() => { StartMainActivity(); });
            tk.Start();
        }

        async void StartMainActivity()
        {
            await Task.Run(() =>
            {
                Task.Delay(15000);
                StartActivity(new Intent(Application.Context, typeof(Test)));
            });
        }


    }
}