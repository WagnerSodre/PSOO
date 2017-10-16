using Android.App;
using Android.Widget;
using Android.OS;
using PSOO.Dominio;

namespace PSOO.App
{
    [Activity(Label = "PSOO.App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            var aa = new Usuario();
        }
    }
}

