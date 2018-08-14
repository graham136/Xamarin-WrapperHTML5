//Add webview to your layout in visualstudio 2017
// I called mine webView12
// make sure your html5 file index.html is put in assets folder for your solution.
// all other files which index.html links must be in assest folder as well.



using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            WebView localWebView = FindViewById<WebView>(Resource.Id.webView12); // found localwebview
            localWebView.Settings.JavaScriptEnabled = true;// enabled javascript

            localWebView.LoadUrl("file:///android_asset/index.html");// load local url
        }
    }
}