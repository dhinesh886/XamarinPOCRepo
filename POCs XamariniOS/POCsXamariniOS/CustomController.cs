using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace POCsXamariniOS
{
	partial class CustomController : UIViewController
	{
		public CustomController (IntPtr handle) : base (handle)
		{
		}

        partial void UIButton14_TouchUpInside(UIButton sender)
        {
            CustomControllerThree cv = this.Storyboard.InstantiateViewController("CustomControllerThree") as CustomControllerThree;
            this.NavigationController.PushViewController( cv,true);
        }
	}
}
