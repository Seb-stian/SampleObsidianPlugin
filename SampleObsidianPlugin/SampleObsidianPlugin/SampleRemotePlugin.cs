using Obsidian.API.Plugins;
using Obsidian.API.Plugins.Services;

namespace SampleObsidianPlugin
{
    [Plugin(Name = "Sample Remote Plugin", Authors = "Seb-stian", Version = "1.0",
        Description = "Sample plugin used for remote plugin testing.",
        ProjectUrl = "https://github.com/Seb-stian/SampleObsidianPlugin")]
    public class SampleRemotePlugin : PluginBase
    {
        [Inject] public ILogger Logger { get; set; }

        public void OnLoad()
        {
            Logger.Log("Hello from github.com/Seb-stian/SampleObsidianPlugin!");
        }

        // For dependencies
        public void Spam(string message)
        {
            Spam(message, 10);
        }

        // For dependencies
        public void Spam(string message, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Logger.LogDebug(message);
            }
        }
    }
}
