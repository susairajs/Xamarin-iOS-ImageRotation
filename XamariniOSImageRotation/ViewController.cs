using System;
using UIKit;

using CoreGraphics;

namespace XamariniOSImageRotation
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnRotate_TouchUpInside(UIButton sender)
		{
			image1.Transform = CGAffineTransform.MakeRotation((float)Math.PI / 4);
			View.AddSubview(image1);
		   
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
