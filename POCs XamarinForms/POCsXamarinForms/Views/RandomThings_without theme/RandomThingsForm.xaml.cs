using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class RandomThingsForm1 : ContentPage
	{
		public RandomThingsForm1 ()
		{
			InitializeComponent ();

			btnSave.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				App.Database.SaveItem (todoItem);
				Navigation.PopAsync ();
			};
			 
			btnDelete.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				App.Database.DeleteItem (todoItem.ID);
				Navigation.PopAsync ();
			};
			 
			btnCancel.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				Navigation.PopAsync ();
			};

			btnSpeak.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				DependencyService.Get<ITextToSpeech> ().Speak (todoItem.Name + " " + todoItem.Notes);
			};
		}

	}
}

