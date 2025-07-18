using GameReaderCommon;

namespace FFBeast.ViewModels {
    public class ProfilesViewModel : ViewModelBase {
        private readonly IGameManager gameManager;

        private bool useDefaultSettings { get; set; } = true;
        private bool enableEffectsView { get; set; }

        public string SectionTitle => "Profile for " + gameManager.GameDisplayName;

        public bool UseDefaultSettings {
            get => useDefaultSettings;
            set {
                useDefaultSettings = value;
                EnableEffectsView = !useDefaultSettings;
                OnPropertyChanged();
            }
        }
        
        public bool EnableEffectsView {
            get => enableEffectsView;
            set {
                enableEffectsView = value;
                OnPropertyChanged();
            }
        }

        public EffectsViewModel EffectsViewModel { get; }
        
        public ProfilesViewModel(IGameManager gameManager) {
            this.gameManager = gameManager;
            this.EffectsViewModel = new EffectsViewModel();
        }
    }
}