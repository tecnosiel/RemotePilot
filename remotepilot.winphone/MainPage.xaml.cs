using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Xamarin.Forms;


namespace RemotePilot.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage // superclass new in 1.3
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            global::Xamarin.Forms.Forms.Init();
            MR.Gestures.WinPhone.Settings.LicenseKey = "HPCZ-BSNZ-3232-37W2-J5VX-RUSM-NRQ5-HSQF-WSQN-MTJQ-UPL6-4MXJ-CSDW";
            LoadApplication(new RemotePilot.App()); // new in 1.3
        }
    }
}
