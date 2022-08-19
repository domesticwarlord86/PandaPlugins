using Buddy.Coroutines;
using ff14bot;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.Enums;
using ff14bot.NeoProfiles;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Collections.Generic;
using TreeSharp;
using System;
using System.Collections.Generic;
using LlamaLibrary.Helpers;
using LlamaLibrary.Logging;


namespace Extractor
{
    public class Extractor : BotPlugin
    {
        private Composite _coroutine;

        public override string Author { get { return "DomesticWarlord"; } }
        public override string Name { get; } = NameValue;
				private static readonly string NameValue = "Extractor";
        public override Version Version { get { return new Version(1, 0, 0); } }
				private static readonly LLogger Log = new LLogger(NameValue, Colors.Aquamarine);
        
        public override async void OnInitialize()
        {
					_coroutine = new ActionRunCoroutine(r => PluginTask());
        }

        public override void OnEnabled()
        {
            TreeRoot.OnStart += OnBotStart;
            TreeRoot.OnStop += OnBotStop;
            TreeHooks.Instance.OnHooksCleared += OnHooksCleared;

            if (TreeRoot.IsRunning) { AddHooks(); }
        }

        public override void OnDisabled()
        {
            TreeRoot.OnStart -= OnBotStart;
            TreeRoot.OnStop -= OnBotStop;
            RemoveHooks();
        }

        public override void OnShutdown() { OnDisabled(); }

        public override bool WantButton => false;


        private void AddHooks()
        {
            Logging.Write(Colors.Aquamarine, "Adding Extractor Hook");
            TreeHooks.Instance.AddHook("TreeStart", _coroutine);
        }

        private void RemoveHooks()
        {
            Logging.Write(Colors.Aquamarine, "Removing Extractor Hook");
            TreeHooks.Instance.RemoveHook("TreeStart", _coroutine);
        }

        private void OnBotStop(BotBase bot) { RemoveHooks(); }

        private void OnBotStart(BotBase bot) { AddHooks(); }

        private void OnHooksCleared(object sender, EventArgs e) { RemoveHooks(); }
        
        private static async Task<bool> PluginTask()
        {
						if (Core.Me.InCombat || !Core.Me.IsAlive || FateManager.WithinFate) return false;
					
						await ExtractMateria();
            return false;
        }

        internal static async Task ExtractMateria()
        {
																	
            if (InventoryManager.FilledInventoryAndArmory.Any(x => x.SpiritBond == 100f) && InventoryManager.FreeSlots > 0)
            {
								await LlamaLibrary.Helpers.GeneralFunctions.StopBusy(leaveDuty: false);
                Log.Information($"Extracting Materia from gear");
                await LlamaLibrary.Utilities.Inventory.ExtractFromAllGear();
            }
        }        

    }
    

}
