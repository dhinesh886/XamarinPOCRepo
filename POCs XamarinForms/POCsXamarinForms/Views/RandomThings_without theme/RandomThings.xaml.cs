using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class RandomThings1 : ContentPage
	{
		public RandomThings1 ()
		{
			InitializeComponent ();

			listView.ItemSelected += (sender, e) => {
				var todoItem = (TodoItem)e.SelectedItem;
				var todoPage = new RandomThingsForm ();
				todoPage.BindingContext = todoItem;
				Navigation.PushAsync (todoPage);
			};
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			listView.ItemsSource = App.Database.GetItems ();
		}
		void OnPlusClicked(object sender, EventArgs args)
		{
			var todoItem = new TodoItem ();
			var todoPage = new RandomThingsForm ();
			todoPage.BindingContext = todoItem;
			Navigation.PushAsync (todoPage);
		}
		void OnBackClicked(object sender, EventArgs args)
		{
			Navigation.PopAsync ();
		}
	}
}

