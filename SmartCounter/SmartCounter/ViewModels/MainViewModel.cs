using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SmartCounter.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string counter = string.Empty;
        public string Count
        {
            get => counter;
            set
            {
                if (counter == value)
                    return;

                counter = value;
                OnPropertyChanged(nameof(Count));
            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string count)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(count));
        }
    }
}
