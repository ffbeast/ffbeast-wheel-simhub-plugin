using GameReaderCommon;

namespace FFBeast.ViewModels {
    public class ProfilesViewModel : ViewModelBase {
        private readonly IGameManager gameManager;

        private bool overrideDefaultSettings { get; set; }

        public string SectionTitle => "Profile for " + gameManager.GameDisplayName;

        public bool OverrideDefaultSettings {
            get => overrideDefaultSettings;
            set {
                overrideDefaultSettings = value;
                OnPropertyChanged();
            }
        }

        public EffectsViewModel EffectsViewModel { get; }
        
        public ProfilesViewModel(IGameManager gameManager) {
            this.gameManager = gameManager;
            this.EffectsViewModel = new EffectsViewModel();
            OverrideDefaultSettings = false;
        }
    }
}