using MyFirstAppMonkeyFinder.Model;
using MyFirstAppMonkeyFinder.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstAppMonkeyFinder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonkeyListView : ContentPage
    {
        public MonkeyListView()
        {
            InitializeComponent();
            this.BindingContext = new MonkeyViewModel();
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = e.SelectedItem as MonkeyModel;
            if ( monkey == null)
            {
                return;
            }
             await Navigation.PushAsync(new MonkeyDetailView(monkey));
        }
    }
}