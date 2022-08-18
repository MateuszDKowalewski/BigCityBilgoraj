using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace BigCityBilgoraj.Tutorial.Content.Items
{
    internal class TutorialItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutoriasl Item");
            Tooltip.SetDefault("This is tutorial item");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(copper: 5);
            Item.maxStack = 999;
        }
    }
}
