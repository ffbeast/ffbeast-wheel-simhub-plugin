using GameReaderCommon;
using SimHub.Plugins;


using System;
using System.Drawing;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using SimHub.Plugins.Devices;

namespace FFBeast
{
    [PluginDescription("Controls FFBeast wheel settings and effects augmentation")]
    [PluginAuthor("FFBeast")]
    [PluginName("FFBeast Commander")]
    public class FFBeastPlugin : IPlugin, IDataPlugin, IWPFSettingsV2
    {
        public FFBeastView View;
        public FFBeastSettings Settings;
        public PluginManager PluginManager { get; set; }
        public ImageSource PictureIcon => this.ToIcon(Sdk.Plugin.Properties.Resources.sdkmenuicon);
        public string LeftMenuTitle => "FFBeast Commander";

        public void DataUpdate(PluginManager pluginManager, ref GameData data){
            object a = pluginManager.GetPropertyValue("DataCorePlugin.CurrentGame");

            if (data.GameRunning){
                pluginManager.SetPropertyValue("FFBeastCommander.Computed.TestValue", this.GetType(), a);
            }
        }
        public void End(PluginManager pluginManager){
            this.SaveCommonSettings("FFBeastSettings", Settings);
        }
        public System.Windows.Controls.Control GetWPFSettingsControl(PluginManager pluginManager){
            return View = new FFBeastView(this, pluginManager.GameManager);
        }
        public void Init(PluginManager pluginManager){
            Settings = this.ReadCommonSettings<FFBeastSettings>("FFBeastSettings", () => new FFBeastSettings());
            pluginManager.SetPropertyValue("DataCorePlugin.CurrentGame", this.GetType(), 10);
            
        }

        public BitmapImage Icon {
            get {
                 Icon icon = SystemIcons.Information; // Or use .Warning, .Error, etc.
                 var stream = new MemoryStream();
                icon.ToBitmap().Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Position = 0;

                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = stream;
                image.EndInit();
                image.Freeze(); // Optional: makes it thread-safe

                return image;
            }
        }

        public string Name {
            get => "CoolName";
        }
        public string Brand {
            get => "Cool description";
        }
    }
}
