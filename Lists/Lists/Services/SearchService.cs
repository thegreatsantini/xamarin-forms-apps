using System;
using System.Collections.Generic;
using Lists.Models;
using System.Linq;
namespace Lists.Services
{
    public class SearchService
    {
        private List<Search> _searches = new List<Search>
        {
            new Search
            {
                Id = 1,
                Location = "Ibiza",
                CheckIn = new DateTime(2016, 9 , 1),
                CheckOut = new DateTime(2016, 11, 1)
            },
            new Search
            {
                Id = 2,
                Location = "Florance",
                CheckIn = new DateTime(2016, 12 , 1),
                CheckOut = new DateTime(2017, 1, 7)
            }
        };
        public IEnumerable<Search> GetRecentSearches( string filter = null )
        {
            if (String.IsNullOrWhiteSpace(filter))
                return _searches;
            return _searches.Where(s => s.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }
        public void DeleteSearch(int searchId)
        {
            _searches.Remove(_searches.Single(s => s.Id == searchId));
        }
    }
}
