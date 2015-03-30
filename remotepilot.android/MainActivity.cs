using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;

namespace RemotePilot.Droid
{
    [Activity(Label = "RemotePilot", Icon = "@drawable/icon", MainLauncher = true,
ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity :
        global::Xamarin.Forms.Platform.Android.FormsApplicationActivity // superclass new in 1.3
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            MR.Gestures.Android.Settings.LicenseKey = "HPCZ-BSNZ-3232-37W2-J5VX-RUSM-NRQ5-HSQF-WSQN-MTJQ-UPL6-4MXJ-CSDW";
            LoadApplication(new App()); // method is new in 1.3
        }
    }
}

