using HarmonyLib;
using InventorySystem.Items.Usables.Scp244;

namespace InventorySystem.Items.Usables
{
    [HarmonyPatch(typeof(Scp244Spawner), nameof(Scp244Spawner.SpawnScp244))]
    internal class Scp244Item
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
