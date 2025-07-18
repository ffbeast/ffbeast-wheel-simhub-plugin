using GameReaderCommon;

namespace FFBeast.ViewModels {
    public class MainPluginViewModel : ViewModelBase {
        public EffectsViewModel EffectsViewModel { get; }
        public ProfilesViewModel ProfilesViewModel { get; }

        public MainPluginViewModel(IGameManager gameManager) {
            EffectsViewModel = new EffectsViewModel();
            ProfilesViewModel = new ProfilesViewModel(gameManager);
        }
    }
}