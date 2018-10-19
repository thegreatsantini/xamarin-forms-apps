using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists.Models;
using Xamarin.Forms;

namespace Lists
{
    public partial class Selection : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Clicked", contact.Name, "OK");
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
            //DisplayAlert("Clicked", contact.Name, "OK");
        }

        ObservableCollection<Contact> GetContacts()
        {
            return new ObservableCollection<Contact>
            {
                new Contact { Name="Lucas", ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Sierra", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey Let's talk" }
            };
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContacts();
        }

        //void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    var contact = e.SelectedItem as Contact;
        //    DisplayAlert("Selected", contact.Name, "OK");
        //}

        //void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //{
        //    var contact = e.Item as Contact;
        //    DisplayAlert("Tapped", contact.Name, "OK");
        //}

        public Selection()
        {
            InitializeComponent();

            _contacts = GetContacts();

            listView.ItemsSource = _contacts;
        }
    }
}
