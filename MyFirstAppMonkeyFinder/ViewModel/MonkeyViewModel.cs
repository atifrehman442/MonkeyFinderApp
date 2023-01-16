using MyFirstAppMonkeyFinder.Model;
using MyFirstAppMonkeyFinder.Servies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyFirstAppMonkeyFinder.ViewModel
{
    public class MonkeyViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MonkeyModel> Monkeys { get; set; } = new ObservableCollection<MonkeyModel>();
        MonkeyService monkeyService = new MonkeyService();
        public MonkeyViewModel()
           
        {
            _ = GetMonkeyDataAsync();
            
        }

        public async System.Threading.Tasks.Task GetMonkeyDataAsync()
        {
      
                var monkeyData = await monkeyService.GetMonkeyData();
                if (monkeyData != null)
                {
                    foreach (var mon in monkeyData)
                    {
                        Monkeys.Add(mon);
                    }
                }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
