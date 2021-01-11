using ExpanderSample.Models;

using System.Collections.ObjectModel;

namespace ExpanderSample.ViewModels
{
    public class NameTagsViewModel
    {
        public ObservableCollection<NameTagModel> NameTags { get; set; }
        public NameTagsViewModel()
        {
            NameTags = new ObservableCollection<NameTagModel>
            {
                new NameTagModel (){Name="Nour",Age=22,Height=189},
                new NameTagModel (){Name="John",Age=26,Height=184},
                new NameTagModel (){Name="Sam",Age=25,Height=180},
                new NameTagModel (){Name="Betty",Age=23,Height=176},
                new NameTagModel (){Name="Alex",Age=29,Height=175},
            };
        }
    }
}
