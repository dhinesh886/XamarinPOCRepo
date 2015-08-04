using System;
using System.Collections.Generic;
using System.Threading;
using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}
		protected override void OnAppearing ()
		{
			base.OnAppearing ();


			var goXamlButton = new Button { Text = " Go With Xaml " , TextColor= Color.Black, BackgroundColor= Color.Gray};
			goXamlButton.Clicked += (sender, e) => { 
				Navigation.PushAsync (new MenuPage()); 
			};

			var goCodeButton = new Button { Text = " Go With Code Only " , TextColor= Color.Black, BackgroundColor= Color.Gray };
			goCodeButton.Clicked += (sender, e) => {
				Navigation.PushAsync (new TodoListPage()); 
			};
			// The root page of your application
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "Welcome " + ((UserProfile)BindingContext).Name
					},
					goCodeButton,
					goXamlButton
				}
			};
		}
	}
}

