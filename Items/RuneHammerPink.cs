using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HelperMod.Items
{
    public class RuneHammerPink : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rune Hammer");
        }

        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
            item.scale = .9f;
            item.autoReuse = true;
            item.melee = true;
            item.damage = 41;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = 1;
        }

        public override bool CanUseItem(Player player)
        {
            return NPC.downedBoss2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PinkBrick, 15);
            recipe.AddIngredient(ItemID.Wood, 12);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}