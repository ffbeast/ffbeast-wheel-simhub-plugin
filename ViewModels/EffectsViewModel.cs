using System;
using GameReaderCommon;

namespace FFBeast.ViewModels {
    public class EffectsViewModel : ViewModelBase {
        private readonly IGameManager gameManager;

        private bool premiumDeviceConnected;
        public string Game => gameManager.GameDisplayName + " effects profile";

        public bool PremiumDeviceConnected {
            get => premiumDeviceConnected;
            set {
                premiumDeviceConnected = value;
                OnPropertyChanged();
            }
        }

        public EffectsViewModel(IGameManager gameManager) {
            this.gameManager = gameManager;
        }
    }
}