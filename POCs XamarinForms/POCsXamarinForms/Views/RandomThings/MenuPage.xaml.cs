using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();

			 
			btnTskMaster.Clicked += (sender, e) => { 
				Navigation.PushAsync (new RandomThings()); 
			};
			btnUsrMaster.Clicked += (sender, e) => { 
				Navigation.PushAsync (new UserProfileList()); 
			};
			btnImages.Clicked += (sender, e) => { 
				Navigation.PushAsync (new WorkingWithBindings()); 
			};
		}
	}
}

