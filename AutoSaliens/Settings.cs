using System.IO;
using AutoSaliens.Console;
using Newtonsoft.Json;

namespace AutoSaliens
{
    internal class Settings
    {
        public bool EnableNetworkTolerance { get; set; } = true;

        public int GameTime { get; set; } = 110;

        public string OverridePlanetId { get; set; }

        public AutomationStrategy Strategy { get; set; } =
            AutomationStrategy.MostDifficultPlanetsFirst |
            AutomationStrategy.MostCompletedPlanetsFirst |
            AutomationStrategy.MostDifficultZonesFirst |
            AutomationStrategy.MostCompletedZonesFirst |
            AutomationStrategy.TopDown;

        public string Token { get; set; }

        public void Save()
        {
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(this, Formatting.Indented));
            Shell.WriteLine("Saved settings to settings.json");
        }
    }
}
