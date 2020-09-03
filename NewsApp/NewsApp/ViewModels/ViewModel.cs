using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace NewsApp.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigate Navigation { get; set; } = new Navigator();
    }
}
