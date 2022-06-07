using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Media;
using Buddy.Coroutines;
using ff14bot;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Helpers;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.RemoteWindows;
using LlamaLibrary.Helpers;
using LlamaLibrary.Logging;
using TreeSharp;
using Action = TreeSharp.Action;

namespace Vulcan
{
    public class Vulcan : BotPlugin
    {
        private Composite _coroutine;

        private static readonly string NameValue = "Vulcan";

        private static readonly LLogger LogVulcan = new LLogger(NameValue, Colors.Firebrick);

        private static ActionRunCoroutine hook;
        private MethodInfo _orderMethod;

        private Composite _root;
        public override string Author => " DomesticWarlord86";
        public override Version Version => new Version(1, 0);
        public override string Name => _Name;
        public override bool WantButton => true;
        private VulcanSettingsFrm settings;

        public override void OnPulse()
        {
        }

        public override async void OnInitialize()
        {
            _coroutine = new ActionRunCoroutine(r => PluginTask());
        }

        public override void OnButtonPress()
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new VulcanSettingsFrm();
            }

            try
            {
                settings.Show();
                settings.Activate();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        
        public static string _Name => "Vulcan";

        private static async Task<bool> PluginTask()
        {
            if (Core.Me.InCombat || !Core.Me.IsAlive || FateManager.WithinFate || DutyManager.InInstance) return false;

            var r = InventoryManager.EquippedItems.Any(item =>
                item.Item != null && item.Item.RepairItemId != 0 &&
                item.Condition < VulcanSettings.Instance.RepairThreshold);

            if (r)
            {
                LogVulcan.Information($"Going to repair gear.");
                TreeRoot.StatusText = $"Going to repair gear";

                var mender = LlamaLibrary.Helpers.NPC.NpcHelper.GetClosestNpc(Menders.ListOfMenders);

                await LlamaLibrary.Helpers.Navigation.GetToNpc(mender);

                await UseMender(mender.NpcId);
            }

            return false;
        }

        public static async Task UseMender(uint MenderId)
        {


            var npcId = GameObjectManager.GetObjectByNPCId(MenderId);

            if (!npcId.IsWithinInteractRange)

            {
                var _target = npcId.Location;
                Navigator.PlayerMover.MoveTowards(_target);
                while (_target.Distance2D(Core.Me.Location) >= 4)
                {
                    Navigator.PlayerMover.MoveTowards(_target);
                    await Coroutine.Sleep(100);
                }

                Navigator.PlayerMover.MoveStop();
            }
            
            npcId.Interact();

            await Coroutine.Wait(10000, () => Repair.IsOpen || SelectIconString.IsOpen);

            if (!Repair.IsOpen && !SelectIconString.IsOpen)
            {
                LogVulcan.Information($"Window didn't open for some reason, interacting again.");
                npcId.Interact();
                await Coroutine.Wait(10000, () => Repair.IsOpen || SelectIconString.IsOpen);
            }

            if (SelectIconString.IsOpen && Menders.SelectIconStringIndexes.ContainsKey(MenderId))
            {
                LogVulcan.Information($"Clicking slot {Menders.SelectIconStringIndexes} to open repair widnow");
                SelectIconString.ClickSlot(Menders.SelectIconStringIndexes[MenderId]);
                await Coroutine.Wait(10000, () => Repair.IsOpen);
            }

            if (Repair.IsOpen)
            {
                LogVulcan.Information($"Selecting Repair All.");
                Repair.RepairAll();
                await Coroutine.Wait(10000, () => SelectYesno.IsOpen);
                {
                    SelectYesno.Yes();
                    await Coroutine.Sleep(500);
                    Repair.Close();
                }
            }
        }

        public static bool Repairing { get; set; }

        private void OnBotStop(BotBase bot)
        {
            RemoveHooks();
        }

        private void OnBotStart(BotBase bot)
        {
            AddHooks();
        }

        public override void OnShutdown()
        {
            TreeRoot.OnStart -= OnBotStart;
            TreeRoot.OnStop -= OnBotStop;
            RemoveHooks();
        }

        private void AddHooks()
        {
            LogVulcan.Information($"Adding {NameValue} Hook");

            TreeHooks.Instance.AddHook("TreeStart", _coroutine);
        }

        private void RemoveHooks()
        {
            LogVulcan.Information($"Removing {NameValue} Hook");
            TreeHooks.Instance.RemoveHook("TreeStart", _coroutine);
        }

        private void OnHooksCleared(object sender, EventArgs e)
        {
            AddHooks();
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
    }
}