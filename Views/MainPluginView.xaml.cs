using System.Windows.Controls;
using FFBeast;
using GameReaderCommon;
using FFBeast.ViewModels;

namespace FFBeast.Views {
    public partial class MainPluginView : UserControl {
        public MainPluginView(IGameManager pluginManagerGameManager) {
            DataContext = new MainPluginViewModel(pluginManagerGameManager);
            InitializeComponent();
        }
    }
}