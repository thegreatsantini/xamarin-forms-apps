using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lists.Models
{
    public class SearchGroups : ObservableCollection<Search>
    {
        public string Title { get; set; }

        public SearchGroups(string title, IEnumerable<Search> searches = null) : base(searches)
        {
            Title = title;
        }
    }
}
