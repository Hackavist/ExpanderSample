using ExpanderSample.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpanderSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NameTagsPage : ContentPage
    {
        readonly NameTagsViewModel NameTagsVM;
        public NameTagsPage()
        {
            InitializeComponent();
            NameTagsVM = new NameTagsViewModel();
            this.BindingContext = NameTagsVM;
        }
    }
}