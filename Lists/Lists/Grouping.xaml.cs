using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists.Models;
using Xamarin.Forms;



namespace Lists
{
    public partial class Grouping : ContentPage
    {
        public Grouping()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("L", "L")
                {
                    new Contact{ Name="Lucas", ImageUrl="http://lorempixel.com/100/100/people/1" }
                },
                new ContactGroup("G", "G")
                {
                new Contact{ Name="Graeme", ImageUrl="http://lorempixel.com/100/100/people/2", Status="Hey Let's talk"  }
                }
            };

        }
    };
}
