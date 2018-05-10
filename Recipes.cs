using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HelperMod
{
    public class Recipes : ModItem
    {
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(ItemID.RecallPotion, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.MagicMirror, 1);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.Gel, 25);
            recipe2.AddIngredient(ItemID.Wood, 12);
            recipe2.AddIngredient(ItemID.FallenStar, 3);
            recipe2.AddTile(TileID.WorkBenches);
            recipe2.SetResult(ItemID.SlimeStaff);
            recipe2.AddRecipe();
        }
    }
}