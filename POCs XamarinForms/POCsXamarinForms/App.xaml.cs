using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();
			database = new POCDB ();
			MainPage = new NavigationPage (new WorkingWithBindings());
			//MainPage = new NavigationPage (new Login());
		}
		static POCDB database;

		public static POCDB Database {
			get {
				return database;
			}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

