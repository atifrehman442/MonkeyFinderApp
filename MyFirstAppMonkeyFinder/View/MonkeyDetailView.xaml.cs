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
    public partial class MonkeyDetailView : ContentPage
    {

        public MonkeyDetailView(MonkeyModel monkey)
        {
            InitializeComponent();
            BindingContext = new MonkeyDetailViewModel(monkey);
        }
    }
}