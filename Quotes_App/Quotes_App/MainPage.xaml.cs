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
        private const string Quote1 = "Nothing is given everything is earned";
        private const string Quote2 = "I'm too drunk to taste this chicken";
        private const string Quote3 = "The winning team is the one with the most points";
        private List<string> QuotesList;
        private Dictionary<string, string> QuotesDictionary = new Dictionary<string, string>();
        private int index;

        public void GetQuotes()
        {
            var quotesFromDatabase = new List<string>(){
                Quote1,
                Quote2,
                Quote3
            };

            QuotesList = quotesFromDatabase;
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                if (index == QuotesList.Count() - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }

                QuoteLabel.Text = QuotesList[index];
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Test method
        /// </summary>
        /// <param name="quotes">Quotes.</param>
        public void Derp(List<string> quotes)
        {
            QuotesList = quotes;
        }




        public MainPage()
        {
            InitializeComponent();
            GetQuotes();
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

    public class FamilyMember
    {
        int age { get; set; }
        string name { get; set; }
        string phoneNumber { get; set; }
    }
}
