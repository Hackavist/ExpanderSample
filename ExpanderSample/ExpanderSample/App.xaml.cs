using ExpanderSample.Views;

using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpanderSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NameTagsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
