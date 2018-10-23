using System;
using System.Collections.Generic;
using System.Linq;
using Lists.Models;
using Lists.Services;
using Xamarin.Forms;

namespace Lists
{
    public partial class ListsExercise : ContentPage
    {
        private SearchService _searchService;
        private List<SearchGroup> _searchGroups;
            
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {


        }

        public ListsExercise()
        {
            _searchService = new SearchService();
            InitializeComponent();

            PopulateListView

        }
    }
}
