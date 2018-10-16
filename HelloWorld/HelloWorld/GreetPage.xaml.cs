using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static Xamarin.Forms.Device;

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.55; 
            // one way of setting padding for differant palatforms
            //double top;
            //switch ( Device.RuntimePlatform )
            //{
            //    case Device.iOS:
            //        top = 20;
            //        break;
            //    case Device.Android:
            //    case Device.UWP:
            //    default:
            //        top = 0;
            //        break;
            //}
            //Padding = new Thickness(5, top, 5, 0);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "OK");
        }
    }
}
