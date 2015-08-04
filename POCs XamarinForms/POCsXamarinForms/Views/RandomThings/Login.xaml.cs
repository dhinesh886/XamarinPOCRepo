using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();

			btnLogin.Clicked += (sender, e) => {
				 
				var user = App.Database.AuthenticateUser (etyUserId.Text, etyPassword.Text);
				if (user !=null )
				{
					var welcomePage = new WelcomePage();
					welcomePage.BindingContext = user;
					Navigation.PushAsync (welcomePage);
				}
				else
				{
					lblMessage.Text = "Invalid Userid or Password!!";
				}
			};
		}
	}
}

