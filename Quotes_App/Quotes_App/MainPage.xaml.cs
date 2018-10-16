using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quotes_App
{
    public partial class MainPage : ContentPage
    {
        private string Quote1 = "Nothing is given everything is earned";
        private string Quote2 = "I'm too drunk to taste this chicken";
        private string Quote3 = "The winning team is the one with the most points";
        int index = 0;

        string[] QuotesList;
        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            QuotesList = new string[] { Quote1, Quote2, Quote3 };
            if ( index == QuotesList.Count() - 1 ) {
                index = 0;
                QuoteLabel.Text = QuotesList[index];
            }
            else {
                index++;
                QuoteLabel.Text = QuotesList[index];
            }
        }

        public MainPage()
        {
            InitializeComponent();

            //WHy do I have to repeat this line?
            QuotesList = new string[] { Quote1, Quote2, Quote3 };

            QuoteLabel.Text = QuotesList[0];


            //QuoteLabel.Text = "Testing";
            //QuoteLabel.FontSize = 12;
            //QuoteLabel = new Label
            //{
            //    FontSize = 64,
            //    FontAttributes = FontAttributes.Bold,
            //    Text = "Medium Bold Font"
            //};

        }
    }
}
