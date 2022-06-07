using System.ComponentModel;
using System.IO;
using ff14bot.Helpers;
using LlamaLibrary.Helpers;

namespace Vulcan
{
    public class VulcanSettings : JsonSettings
    {
        private static VulcanSettings _settings;

        public static VulcanSettings Instance => _settings ?? (_settings = new VulcanSettings());

        private int _repairThreshold;

        public VulcanSettings() : base(Path.Combine(JsonHelper.UniqueCharacterSettingsDirectory, "VulcanSettings.json"))
        {
        }

        [Description("Repair threshold")]
        [DefaultValue(20)] 
        public int RepairThreshold
        {
            get => _repairThreshold;
            set
            {
                if (_repairThreshold != value)
                {
                    _repairThreshold = value;
                    Save();
                }
            }
        }
    }
}