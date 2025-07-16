using GameReaderCommon;
using SimHub.Plugins;
using SimHub.Plugins.Audio;

namespace FFBeast {
    public class FFBeastViewModel:ViewModelBase {
        
        private readonly IGameManager gameManager;

        private string formula;

        public string Formula {
            get => formula;
            set {
                formula = value;
                OnPropertyChanged();
            }
        }

        public FFBeastViewModel(IGameManager gameManager) {
            this.gameManager = gameManager;
        }

        public string Title { get; set; } = "Hello from VM";
        
        public string Game => gameManager.GameDisplayName;
    }
}