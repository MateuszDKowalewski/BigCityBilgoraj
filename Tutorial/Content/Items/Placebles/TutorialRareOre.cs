using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace BigCityBilgoraj.Tutorial.Content.Items.Placebles
{
    internal class TutorialRareOre : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Rare Ore");
            Tooltip.SetDefault("This is tutorial rare ore");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.SortingPriorityMaterials[Type] = 59;
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.value = Item.buyPrice(copper: 100);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useTurn = true;
            Item.autoReuse = true;

            Item.createTile = ModContent.TileType<Tiles.TutorialRareOre>();
        }
    }
}
