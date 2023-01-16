using MyFirstAppMonkeyFinder.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyFirstAppMonkeyFinder.ViewModel
{
    public class MonkeyDetailViewModel : INotifyPropertyChanged
    {

       public MonkeyDetailViewModel(MonkeyModel monkey)
            : this()
        {
            Monkey = monkey;
        }

        public Command OpenMapCommand { get; }

        public MonkeyDetailViewModel()
        {
            OpenMapCommand = new Command(async () => await OpenMapAsync());
        }

        MonkeyModel _monkey;
        public MonkeyModel Monkey
        {
            get => _monkey;
            set
            {
                if (_monkey == value)
                    return;

                _monkey = value;
                OnPropertyChanged();
            }
        }

        async Task OpenMapAsync()
        {
            try
            {
                await Map.OpenAsync(Monkey.Latitude, Monkey.Longitude);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to launch maps: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error, no Maps app!", ex.Message, "OK");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
