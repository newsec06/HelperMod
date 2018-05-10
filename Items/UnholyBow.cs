using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HelperMod.Items
{
    public class UnholyBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unholy Bow");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 64;
            item.scale = .8f; 
            item.damage = 12;
            item.ranged = true;
            item.noMelee = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 8;
            item.useAmmo = AmmoID.Arrow;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = ProjectileID.UnholyArrow;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ebonwood, 20);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.Shadewood, 20);
            recipe2.AddIngredient(ItemID.Vertebrae, 5);
            recipe2.AddIngredient(ItemID.Silk, 3);
            recipe2.AddTile(TileID.WorkBenches);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}