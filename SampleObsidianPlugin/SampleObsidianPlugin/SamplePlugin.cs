using Obsidian.Plugins.API;
using Obsidian.Plugins.API.Services;

namespace SampleObsidianPlugin
{
    [Plugin(Authors = "Seb-stian", Description = "Sample plugin used for remote plugin testing.", Name = "Sample Remote Plugin", ProjectUrl = "https://github.com/Seb-stian/SampleObsidianPlugin", Version = "1.0")]
    public class SamplePlugin : PluginBase
    {
        [Inject] public ILogger Logger { get; set; }

        public void OnLoad()
        {
            Logger.Log("Hello from github.com/Seb-stian/SampleObsidianPlugin!");
        }
    }
}
