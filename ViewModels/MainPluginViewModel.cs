using GameReaderCommon;

namespace FFBeast.ViewModels {
    public class MainPluginViewModel : ViewModelBase {
        private IGameManager gameManager;
        
        public EffectsViewModel EffectsViewModel { get; }
        public ProfilesViewModel ProfilesViewModel { get; }

        public string SectionTitle => "Profile for " + gameManager.GameDisplayName;
        private string connectedDeviceName { get; set; }
        
        public bool DeviceConnected => connectedDeviceName != null;
        
        public string DisplayText => string.IsNullOrEmpty(connectedDeviceName) ? "No compatible devices connected" : connectedDeviceName;
        
        public string ConnectedDeviceName {
            get => connectedDeviceName;
            set {
                connectedDeviceName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DeviceConnected));
                OnPropertyChanged(nameof(DisplayText));
            }
        }
        
        public MainPluginViewModel(IGameManager gameManager) {
            this.gameManager = gameManager;
            EffectsViewModel = new EffectsViewModel();
            ProfilesViewModel = new ProfilesViewModel(gameManager);
            ConnectedDeviceName= "FFBeast Wheel [RC.24.1.3]";
            // ConnectedDeviceName= null;
        }
    }
}