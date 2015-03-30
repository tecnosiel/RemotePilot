using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Xamarin.Forms;

namespace RemotePilot.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : 
	global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate // superclass new in 1.3
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

            MR.Gestures.iOS.Settings.LicenseKey = "HPCZ-BSNZ-3232-37W2-J5VX-RUSM-NRQ5-HSQF-WSQN-MTJQ-UPL6-4MXJ-CSDW";

            LoadApplication (new App ());  // method is new in 1.3

			return base.FinishedLaunching (app, options);
		}
	}
}
