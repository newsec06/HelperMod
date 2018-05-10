using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HelperMod.Items
{
    public class DeathMirror : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Death Mirror");
            Tooltip.SetDefault("Gaze in the mirror to return to you last death position");
        }

        public override void SetDefaults()
        {
            item.height = 48;
            item.width = 48;
            item.scale = .5f;
            item.expert = true;
            item.useStyle = 4;
            item.useAnimation = 40;
            item.useTime = 40;
        }

        public override bool CanUseItem(Player player)
        {
            return player.lastDeathPostion != Vector2.Zero;
        }

        public override bool UseItem(Player player)
        {
            player.Teleport(player.lastDeathPostion + new Vector2(0, -15));
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicMirror, 1);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
            recipe.AddIngredient(ItemID.Obsidian, 5);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}