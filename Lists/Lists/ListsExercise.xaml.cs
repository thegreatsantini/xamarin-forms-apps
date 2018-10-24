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

            PopulateListView(_searchService.GetRecentSearches());

        }

        private void OnSearchTextChanged(object sender , Xamarin.Forms.TextChangedEventArgs eventArgs)
        {
            PopulateListView(_searchService.GetRecentSearches(eventArgs.NewTextValue));
        }

        private void PopulateListView(IEnumerable<Search> searches)
        {
            _searchGroups = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", searches)
            };
            listView.ItemsSource = _searchGroups;
        }
        private void OnDeleteClicked( object sender, System.EventArgs e )
        {
            var search = (sender as MenuItem).CommandParameter as Search;

            //RemoveBinding item locally
            _searchGroups[0].Remove(search);

            //RemoveBinding item from backend
            _searchService.DeleteSearch(search.Id);
        }
        private void OnRefreshing(object sender, System.EventArgs eventArgs)
        {
            PopulateListView(_searchService.GetRecentSearches());

            listView.EndRefresh();
        }
        private void OnSearchSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Selected", search.Location, "OK");
        }
    }
}
