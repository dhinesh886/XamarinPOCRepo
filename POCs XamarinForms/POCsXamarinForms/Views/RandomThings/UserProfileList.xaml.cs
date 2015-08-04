using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class UserProfileList : ContentPage
	{
		public UserProfileList ()
		{
			InitializeComponent ();
			listView.ItemSelected += (sender, e) => {
				var profiles = (UserProfile)e.SelectedItem;
				var profilesPage = new ManageUserProfile ();
				profilesPage.BindingContext = profiles;
				Navigation.PushAsync (profilesPage);
			};
		}
		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			listView.ItemsSource = App.Database.GetUserProfiles ();
		}
		void OnPlusClicked(object sender, EventArgs args)
		{
			var profile = new UserProfile ();
			var profilePage = new ManageUserProfile ();
			profilePage.BindingContext = profile;
			Navigation.PushAsync (profilePage);
		}
	}
}

