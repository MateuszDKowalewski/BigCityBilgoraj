using System;
using Terraria;
using Terraria.ModLoader;

namespace BigCityBilgoraj.Content.Items.Minecarts
{
    internal class ZuzuMobileBuff : ModBuff
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ZuzuMobile");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<ZuzuMobileMount>(), player);
            player.buffTime[buffIndex] = 10;
        }

    }
}
