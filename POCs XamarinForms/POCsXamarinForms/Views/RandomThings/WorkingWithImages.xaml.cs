using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class WorkingWithImages : ContentPage
	{
		public WorkingWithImages ()
		{
			InitializeComponent ();
		}
		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			listView.ItemsSource = App.Database.GetItems ();
		}
	}
}

