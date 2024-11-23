using Exiled.API.Features;
using HarmonyLib;
using System;

namespace CustomPlugin
{
    public class Plugin : Plugin<Config>
    {

        public override string Prefix => "DisableSCP244Spawn";

        public override string Author => "pavlikHTP";

        public override string Name => "AntiSCP244Spawn";

        public override Version Version => new Version(1, 0, 0);

        private Harmony _harmony;
        private string _harmonyId;
        public override void OnEnabled()
        {


            _harmonyId = $"{DateTime.Now.Ticks}";
            _harmony = new Harmony(_harmonyId);
            Log.Debug($"{nameof(OnEnabled)}: Patching..");
            _harmony.PatchAll();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {

            Log.Info($"{Name} has been disabled!");
            _harmony.UnpatchAll();
            base.OnDisabled();
        }

        public override void OnReloaded()
        {
            base.OnReloaded();
        }

    }
}
