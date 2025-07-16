using System.Windows.Controls;
using System.Windows.Input;
using GameReaderCommon;

namespace FFBeast {
    public partial class FFBeastView : UserControl {
        public FFBeastPlugin Plugin { get; }
        

        public FFBeastView() {
            InitializeComponent();
        }

        public FFBeastView(FFBeastPlugin plugin, IGameManager pluginManagerGameManager) : this() {
            this.Plugin = plugin;
            DataContext = new FFBeastViewModel(pluginManagerGameManager);
        }
    }
}
