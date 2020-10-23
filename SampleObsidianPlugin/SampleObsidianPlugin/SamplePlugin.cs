using Obsidian.API.Plugins;
using Obsidian.API.Plugins.Services;

namespace SampleObsidianPlugin
{
    [Plugin(Name = "Sample Remote Plugin", Authors = "Seb-stian", Version = "1.0",
        Description = "Sample plugin used for remote plugin testing.",
        ProjectUrl = "https://github.com/Seb-stian/SampleObsidianPlugin")]
    public class SamplePlugin : PluginBase
    {
        [Inject] public ILogger Logger { get; set; }

        public void OnLoad()
        {
            Logger.Log("Hello from github.com/Seb-stian/SampleObsidianPlugin!");
        }
    }
}
