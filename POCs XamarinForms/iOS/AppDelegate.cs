using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Themes;
using Xamarin.Themes.Core;
using Xamarin.Themes.TrackBeam;

namespace POCsXamarinForms.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			LoadApplication (new App ());
			//ThemeManager.Register<TrackBeamTheme>().Apply();
			//FitpulseTheme.Apply();
			ProlificTheme.Apply();
			return base.FinishedLaunching (app, options);
		}
	}
}

