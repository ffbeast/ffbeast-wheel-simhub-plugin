﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FFBeast {
    public class ViewModelBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}