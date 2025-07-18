using System;
using GameReaderCommon;

namespace FFBeast.ViewModels {
    public class EffectsViewModel : ViewModelBase {

        private bool premiumDeviceConnected;
        public bool PremiumDeviceConnected {
            get => premiumDeviceConnected;
            set {
                premiumDeviceConnected = value;
                OnPropertyChanged();
            }
        }
    }
}