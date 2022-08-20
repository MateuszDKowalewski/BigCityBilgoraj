using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace BigCityBilgoraj.Content.Items.Minecarts
{
    internal class ZuzuMobileItem : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ZuzuMobile");
            Tooltip.SetDefault("Can carry you to Biłgoraj");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 2137;
            ItemID.Sets.SortingPriorityMaterials[Type] = 1;

            MountID.Sets.Cart[Item.mountType] = true;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Minecart);

            // Item.width = 34;
            // Item.height = 26;
            // Item.useTime = 20;
            // Item.useAnimation = 20;
            // Item.useStyle = ItemUseStyleID.Swing;
            // Item.value = Item.sellPrice(gold: 3);
            // Item.rare = ItemRarityID.Green;
            // Item.noMelee = true;
            // Item.mountType = ModContent.MountType<ZuzuMobileMount>();
        }

        public override bool CanUseItem(Player player) => false;

    }

}

