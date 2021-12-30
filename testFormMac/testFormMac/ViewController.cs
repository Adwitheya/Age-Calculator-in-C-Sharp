//using System;

//using AppKit;
//using Foundation;
//using System.Text;

using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AppKit;
using Foundation;
//using System.Windows.Forms;


namespace testFormMac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
                TimerLabel.Title = "";
            }
        }

        partial void SubmitButton(NSButton sender)
        {
            //throw new NotImplementedException();

            var enteredName = NameField.StringValue;
            var enteredCity = CityField.StringValue;
            DateTime enteredDate = (DateTime) DateField.DateValue;
            DateTime dateToday = DateTime.Today;
            var userAge = (int) (((dateToday - enteredDate).TotalDays) / 365);

            var finalString = enteredName + " is in " + enteredCity + " and is " + userAge.ToString() + " years old.";

            //this.TimerLabel.Text += finalString;
            //

            TimerLabel.Title = finalString;
            
            //Console.WriteLine(finalString);
        }

        partial void CancelButton(NSButton sender)
        {
            //throw new NotImplementedException();

            NSApplication.SharedApplication.Terminate(this);
        }
    }
}
