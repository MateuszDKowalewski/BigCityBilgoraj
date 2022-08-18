using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace BigCityBilgoraj.Tutorial.Content.Items.Weapons
{
    internal class TutorialSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutoriasl Sword");
            Tooltip.SetDefault("This is tutorial sword");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 20;
            Item.knockBack = 10f;
            Item.crit = 10;

            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ItemRarityID.Blue;

            Item.UseSound = SoundID.Item1       ;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<TutorialItem>(), 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
