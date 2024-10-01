using System;
using System.ComponentModel;
using System.IO;
using ff14bot.Helpers;

namespace RetainerVentures
{

        public class RetainerVentureSettings : JsonSettings
        {

            private static RetainerVentureSettings _RetainerVentureSettingssettings;

            public static RetainerVentureSettings Instance => _RetainerVentureSettingssettings ?? (_RetainerVentureSettingssettings = new RetainerVentureSettings());
            public RetainerVentureSettings() : base(Path.Combine(CharacterSettingsDirectory, "RetainerVentureSettings.json"))
            {

            }

            private DateTime _lastChecked = new DateTime(1970, 1, 1);
            [Description("Last time we checked for ventures.")]
            [Category("Retainers")]
            [Browsable(true)]
            public DateTime LastChecked
            {
                get => _lastChecked;
                set
                {
                    if (_lastChecked != value)
                    {
                        _lastChecked = value;
                        Save();
                    }
                }
            }

            private int _checkTime;
            [Description("Time to wait in minutes between checking for ventures completed.")]
            [DefaultValue(10)]
            [Category("Retainers")]
            [Browsable(false)]
            public int CheckTime
            {
                get => _checkTime;
                set
                {
                    if (_checkTime != value)
                    {
                        _checkTime = value;
                        Save();
                    }
                }
            }

            private bool _returnHome;
            [Description("Should we retun back to our location after retainers are finished?")]
            [DefaultValue(true)]
            [Category("Retainers")]
            [Browsable(true)]
            public bool ReturnHome
            {
                get => _returnHome;
                set
                {
                    if (_returnHome != value)
                    {
                        _returnHome = value;
                        Save();
                    }
                }
            }
        }



}