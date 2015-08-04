using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCsXamarinForms
{
	public partial class WorkingWithBindings : ContentPage
	{
		public WorkingWithBindings ()
		{
			InitializeComponent ();
			btnDirectBinding.Clicked += (sender, e) => { 
				Navigation.PushAsync (new DirectBinding()); 
			};
			btnSMVVMBinding.Clicked += (sender, e) => { 
				Navigation.PushAsync (new SimpleMVVM()); 
			};
			btnIMVVMBinding.Clicked += (sender, e) => { 
				Navigation.PushAsync (new InteractiveMVVM()); 
			};
			btnCMVVMBinding.Clicked += (sender, e) => { 
				Navigation.PushAsync (new CommandUsingMVVM()); 
			};
		}
	}
}

