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
using Clio.Utilities;
using LlamaLibrary.Helpers;
using LlamaLibrary.Helpers.NPC;
using LlamaLibrary.Logging;
using LlamaLibrary.Retainers;
using ActionType = ff14bot.Enums.ActionType;


namespace RetainerVentures
{
    public class RetainerVentures : BotPlugin
    {
        private Composite _coroutine;

        public override string Author
        {
            get { return "DomesticWarlord"; }
        }

        public override string Name { get; } = NameValue;
        private static readonly string NameValue = "Retainer Ventures";

        private static Location lastLocation;

        public override Version Version
        {
            get { return new Version(1, 0, 0); }
        }

        private static readonly LLogger Log = new LLogger(NameValue, Colors.Aquamarine);
        private DateTime _lastChecked = new DateTime(1970, 1, 1);

        private static readonly uint[] _ventureUnlockQuests = { 66968, 66969, 66970 };

        public override async void OnInitialize()
        {
            _coroutine = new ActionRunCoroutine(r => PluginTask());
        }

        public override void OnEnabled()
        {
            TreeRoot.OnStart += OnBotStart;
            TreeRoot.OnStop += OnBotStop;
            TreeHooks.Instance.OnHooksCleared += OnHooksCleared;

            if (TreeRoot.IsRunning)
            {
                AddHooks();
            }
        }

        public override void OnDisabled()
        {
            TreeRoot.OnStart -= OnBotStart;
            TreeRoot.OnStop -= OnBotStop;
            RemoveHooks();
        }

        public override void OnShutdown()
        {
            OnDisabled();
        }

        private RetainerVentureSettings _settings;
        public override bool WantButton => true;
        public override string ButtonText => "Settings";
        private Form1 _form;
        public static RetainerVentureSettings RetainerVentureSettings => RetainerVentureSettings.Instance;

        public override void OnButtonPress()
        {
            if (_form == null)
            {
                _form = new Form1()
                {
                    Text = "Retainer Venture Settings v" + Version,
                };
                _form.Closed += (o, e) => { _form = null; };
            }

            try
            {
                _form.Show();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void AddHooks()
        {
            Logging.Write(Colors.Aquamarine, "Adding Retainer Hook");
            TreeHooks.Instance.AddHook("TreeStart", _coroutine);
        }

        private void RemoveHooks()
        {
            Logging.Write(Colors.Aquamarine, "Removing Retainer Hook");
            TreeHooks.Instance.RemoveHook("TreeStart", _coroutine);
        }

        private void OnBotStop(BotBase bot)
        {
            RemoveHooks();
        }

        private void OnBotStart(BotBase bot)
        {
            AddHooks();
        }

        private void OnHooksCleared(object sender, EventArgs e)
        {
            RemoveHooks();
        }

        private static async Task<bool> PluginTask()
        {

            if (Core.Me.InCombat || !Core.Me.IsAlive || FateManager.WithinFate || DutyManager.InInstance ||
                WorldHelper.CurrentWorldId != WorldHelper.HomeWorldId)
            {
                return false;
            }

            if (!_ventureUnlockQuests.Any(questId => QuestLogManager.IsQuestCompleted(questId)) ||
                HelperFunctions.FuncNumberOfRetainers() == 0)
            {
                return false;
            }

            var verified = await HelperFunctions.VerifiedRetainerData();
            if (!verified)
            {
                return false;
            }

            var rets = await HelperFunctions.GetOrderedRetainerArray(true);

            var now = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

            if (rets.Any(i =>
                    i.Active && i.VentureTask != 0 && (i.VentureEndTimestamp - now) <= 0 &&
                    SpecialCurrencyManager.GetCurrencyCount(SpecialCurrency.Venture) > 2) &&
                (DateTime.Now - RetainerVentureSettings.LastChecked).TotalMinutes >= 0)
            {
                Log.Information($"Retainers completed, checking for busy.");
                if (!Core.Me.InCombat || Core.Me.IsAlive || !FateManager.WithinFate || !DutyManager.InInstance ||
                    WorldHelper.CurrentWorldId == WorldHelper.HomeWorldId)
                {
                    lastLocation = new LlamaLibrary.Helpers.NPC.Location(WorldManager.ZoneId, Core.Me.Location);

                    Log.Information($"Not busy, running venture task.");
                    await HelperFunctions.CheckVentureTask();
                    RetainerVentureSettings.LastChecked = DateTime.Now;
                }
                else
                {
                    Log.Information($"Too busy, waiting 5.");
                    RetainerVentureSettings.LastChecked.AddMinutes(5);
                }

                await GeneralFunctions.StopBusy();
                if (WorldManager.ZoneId != lastLocation.ZoneId)
                {
                    Log.Information($"Going back to where we were");
                    await LlamaLibrary.Helpers.Navigation.GetTo(lastLocation);
                }

            }

            return false;
        }
    }
}
