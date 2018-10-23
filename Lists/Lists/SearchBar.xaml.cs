using System;
using System.Collections.Generic;
using System.Linq;
using Lists.Models;
using Xamarin.Forms;


namespace Lists
{
    public partial class SearchBar : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        IEnumerable<Contact> GetContacts(string query=null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name="Lucas", ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Sierra", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey Let's talk" }
            };

            if (String.IsNullOrWhiteSpace(query))
                return contacts;

            return contacts.Where( contact => contact.Name.StartsWith(query) );
        }

        public SearchBar()
        {
            InitializeComponent();

            listView.ItemsSource = GetContacts();
        }
    }
}
