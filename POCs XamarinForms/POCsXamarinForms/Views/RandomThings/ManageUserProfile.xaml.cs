using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class ManageUserProfile : ContentPage
	{
		public ManageUserProfile ()
		{
			InitializeComponent ();

			btnSave.Clicked += (sender, e) => {
				var profile = (UserProfile)BindingContext;
				App.Database.SaveUserProfile (profile);
				Navigation.PopAsync ();
			};

			btnDelete.Clicked += (sender, e) => {
				var profile = (UserProfile)BindingContext;
				App.Database.DeleteUserProfile (profile.ID);
				Navigation.PopAsync ();
			};

			btnCancel.Clicked += (sender, e) => {
				var profile = (UserProfile)BindingContext;
				Navigation.PopAsync ();
			};

		}

	}
}

