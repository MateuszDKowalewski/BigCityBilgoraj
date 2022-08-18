using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace BigCityBilgoraj.Tutorial.Content.Items.Placebles
{
    internal class TutorialBar : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Bar");
            Tooltip.SetDefault("This is tutorial bar");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 50;
            ItemID.Sets.SortingPriorityMaterials[Type] = 50;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.value = Item.buyPrice(silver: 1, copper: 75);

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
        }
    }
}
