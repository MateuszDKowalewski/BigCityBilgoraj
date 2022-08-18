using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.Localization;

namespace BigCityBilgoraj.Tutorial.Content.Tiles
{
    internal class TutorialBars : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileShine[Type] = 1100;
            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(200, 200, 200), CreateMapEntryName("MapObject.MetalBar"));
        }

        public override bool Drop(int x, int y)
        {
            Tile t = Main.tile[x, y];
            int style = t.TileFrameX / 18;
            Item.NewItem(
                new EntitySource_TileBreak(x, y),
                new Vector2(x * 16, y * 16),
                new Vector2(16, 16),
                ModContent.ItemType<Items.Placebles.TutorialBar>()
            );
            return base.Drop(x, y);
        }
    }
}
