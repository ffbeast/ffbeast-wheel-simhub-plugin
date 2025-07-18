using System.Windows.Media;
using FFBeast;
using FFBeast.ViewModels;
using GameReaderCommon;
using FFBeast.Views;
using SimHub.Plugins;

namespace FFBeast {
    [PluginDescription("Controls FFBeast wheel settings and effects augmentation")]
    [PluginAuthor("FFBeast Manager")]
    [PluginName("FFBeast Wheel")]
    public class FFBeastPlugin : IPlugin, IDataPlugin, IWPFSettingsV2 {
        public MainPluginView View;
        public FFBeastSettings Settings;
        public PluginManager PluginManager { get; set; }
        public ImageSource PictureIcon => this.ToIcon(FFBeast.Properties.Resources.sdkmenuicon);
        public string LeftMenuTitle => "FFBeast Manager";

        public void DataUpdate(PluginManager pluginManager, ref GameData data) {
            object a = pluginManager.GetPropertyValue("DataCorePlugin.CurrentGame");

            if (data.GameRunning) {
                pluginManager.SetPropertyValue("FFBeastWheel.Computed.TestValue", GetType(), a);
            }
        }

        public void End(PluginManager pluginManager) {
            this.SaveCommonSettings("FFBeastSettings", Settings);
        }

        public System.Windows.Controls.Control GetWPFSettingsControl(PluginManager pluginManager) {
            return new MainPluginView(pluginManager.GameManager);
        }

        public void Init(PluginManager pluginManager) {
            Settings = this.ReadCommonSettings("FFBeastSettings", () => new FFBeastSettings());
        }
    }
}