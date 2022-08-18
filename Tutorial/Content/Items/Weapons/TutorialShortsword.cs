using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using BigCityBilgoraj.Tutorial.Content.Projectiles.Weapons;

namespace BigCityBilgoraj.Tutorial.Content.Items.Weapons
{
    internal class TutorialShortsword : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutoriasl Shortsword");
            Tooltip.SetDefault("This is tutorial shortsword");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Rapier;
            Item.useTime = 12;
            Item.useAnimation = 12;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 17;
            Item.knockBack = 10f;

            Item.value = Item.buyPrice(silver: 20);
            Item.rare = ItemRarityID.Blue;

            Item.UseSound = SoundID.Item1;

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<TutorialShortswordProjectile>();
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
