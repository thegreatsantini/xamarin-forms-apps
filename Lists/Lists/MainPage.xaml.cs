using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists.Models;
using Xamarin.Forms;

namespace Lists
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
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
