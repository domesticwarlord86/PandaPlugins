using System.ComponentModel;
using System.IO;
using ff14bot.Enums;
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
        [Category("Repair Settings")]
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
        
        private bool _fcBuffsEnabled;
        [Description("Whether or not to keep FCBuffs active.")]
        [Category("FCBuff Settings")]
        [DefaultValue(true)]
        public bool FCBuffsEnabled
        {
            get => _fcBuffsEnabled;
            set
            {
                if (_fcBuffsEnabled != value)
                {
                    _fcBuffsEnabled = value;
                    Save();
                }
            }
        }
        
                private FCActions _buff1;
        [Description("FC Buff #1")]
        [DefaultValue(FCActions.The_Heat_of_Battle_II)] //shift +x
        [Category("FCBuff Settings")]
        public FCActions Buff1
        {
            get => _buff1;
            set
            {
                if (_buff1 != value)
                {
                    _buff1 = value;
                    Save();
                }
            }
        }

        private FCActions _buff2;
        [Description("FC Buff #2")]
        [DefaultValue(FCActions.In_Control_II)] //shift +x
        [Category("FCBuff Settings")]
        public FCActions Buff2
        {
            get => _buff2;
            set
            {
                if (_buff2 != value)
                {
                    _buff2 = value;
                    Save();
                }
            }
        }

        private GrandCompany _grandCompany;
        [Description("FC GrandCompany Alliance")]
        [DefaultValue(ff14bot.Enums.GrandCompany.Maelstrom)] //shift +x
        [Category("FCBuff Settings")]
        public GrandCompany GrandCompany
        {
            get => _grandCompany;
            set
            {
                if (_grandCompany != value)
                {
                    _grandCompany = value;
                    Save();
                }
            }
        }
        
        public enum FCActions
        {
            The_Heat_of_Battle = 1,
            Earth_and_Water = 2,
            Helping_Hand = 3,
            A_Mans_Best_Friend = 4,
            Mark_Up = 5,
            Seal_Sweetener = 6,
            Brave_New_World = 7,
            Live_off_the_Land = 8,
            What_You_See = 9,
            Eat_from_the_Hand = 10,
            In_Control = 11,
            That_Which_Binds_Us = 12,
            Meat_and_Mead = 13,
            Proper_Care = 14,
            Back_on_Your_Feet = 15,
            Reduced_Rates = 16,
            Jackpot = 17,
            The_Heat_of_Battle_II = 31,
            Earth_and_Water_II = 32,
            Helping_Hand_II = 33,
            A_Mans_Best_Friend_II = 34,
            Mark_Up_II = 35,
            Seal_Sweetener_II = 36,
            Brave_New_World_II = 37,
            Live_off_the_Land_II = 38,
            What_You_See_II = 39,
            Eat_from_the_Hand_II = 40,
            In_Control_II = 41,
            That_Which_Binds_Us_II = 42,
            Meat_and_Mead_II = 43,
            Proper_Care_II = 44,
            Back_on_Your_Feet_II = 45,
            Reduced_Rates_II = 46,
            Jackpot_II = 47,
            /*The_Heat_of_Battle_III = 61,
            Earth_and_Water_III = 62,
            Helping_Hand_III = 63,
            A_Mans_Best_Friend_III = 64,
            Mark_Up_III = 65,
            Seal_Sweetener_III = 66,
            Live_off_the_Land_III = 68,
            What_You_See_III = 69,
            Eat_from_the_Hand_III = 70,
            In_Control_III = 71,
            That_Which_Binds_Us_III = 72,
            Meat_and_Mead_III = 73,
            Proper_Care_III = 74,
            Reduced_Rates_III = 76,
            Jackpot_III = 77*/
        }
    }
}