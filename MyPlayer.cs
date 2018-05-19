using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace YoyoAttackSpeedWorkaround
{
    class MyPlayer : ModPlayer
    {
        public override void PostUpdateEquips()
        {
            Item held = player.HeldItem;
            if ((held.melee || held.thrown) && held.channel) //likely to be yo-yo
            {
                if (player.meleeSpeed > 2f) player.meleeSpeed = 2f;
            }

            base.PostUpdateEquips();
        }
    }
}
