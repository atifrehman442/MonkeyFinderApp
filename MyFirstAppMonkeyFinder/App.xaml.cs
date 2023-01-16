using MyFirstAppMonkeyFinder.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstAppMonkeyFinder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MonkeyListView())
            {
                BarBackgroundColor = (Color)Resources["Primary"],
         
            };
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
