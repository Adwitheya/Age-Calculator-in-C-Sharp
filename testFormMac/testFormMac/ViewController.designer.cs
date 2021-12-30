// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace testFormMac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField CityField { get; set; }

		[Outlet]
		AppKit.NSDatePicker DateField { get; set; }

		[Outlet]
		AppKit.NSTextField NameField { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell TimerLabel { get; set; }

		[Action ("CancelButton:")]
		partial void CancelButton (AppKit.NSButton sender);

		[Action ("SubmitButton:")]
		partial void SubmitButton (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (NameField != null) {
				NameField.Dispose ();
				NameField = null;
			}

			if (CityField != null) {
				CityField.Dispose ();
				CityField = null;
			}

			if (DateField != null) {
				DateField.Dispose ();
				DateField = null;
			}

			if (TimerLabel != null) {
				TimerLabel.Dispose ();
				TimerLabel = null;
			}
		}
	}
}
