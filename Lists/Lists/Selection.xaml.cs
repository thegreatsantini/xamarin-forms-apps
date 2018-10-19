using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists.Models;
using Xamarin.Forms;

namespace Lists
{
    public partial class Selection : ContentPage
    {
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        public Selection()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name="Lucas", ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Sierra", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey Let's talk" }
            };
        }
    }
}
