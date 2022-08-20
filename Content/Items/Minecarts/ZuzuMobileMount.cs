using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BigCityBilgoraj.Content.Items.Minecarts
{
    internal class ZuzuMobileMount : ModMount
    {

        public override void SetStaticDefaults()
        {

            MountData.Minecart = true;
            MountData.MinecartDirectional = true;

            MountData.runSpeed = 17;
            MountData.dashSpeed = 14;
            MountData.fallDamage = 1f;
            MountData.jumpHeight = 15;
            MountData.spawnDust = 174;
            MountData.jumpSpeed = 5.15f;
            MountData.flightTimeMax = 0;
            MountData.acceleration = 0.08f;
            MountData.blockExtraJumps = true;


        }

    }

}
