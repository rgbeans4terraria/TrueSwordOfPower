using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrueSwordOfPower.Items
{
	public class TrueSwordOfPower : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TrueSwordOfPower"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("You have scowered the world for this sword.\nYour travels have rewarded well.\nIts yours. You earned it.\nEnemies will now try to attack you more from jealousy");
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.defense -= 30;
			target.AddBuff(BuffID.OnFire, 60);
			target.AddBuff(BuffID.Cursed, 60);
			target.AddBuff(BuffID.Ichor, 60);
			target.AddBuff(BuffID.Frostburn, 60);
			target.AddBuff(BuffID.Bleeding, 60);
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Battle, 1, true);
		}

		public override void SetDefaults() 
		{
			item.scale = 2f;
			item.damage = 500;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = Item.buyPrice(platinum:69);
			item.rare = ItemRarityID.Purple;
			item.shoot = mod.ProjectileType("TrueSwordOfPowerProjectile");
			item.shootSpeed = 16f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		//public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		//{
		//	Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
		//	float ceilingLimit = target.Y;
		//	if (ceilingLimit > player.Center.Y - 200f)
		//	{
		//		ceilingLimit = player.Center.Y - 200f;
		//	}
		//	for (int i = 0; i < 3; i++)
		//	{
		//		position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
		//		position.Y -= (100 * i);
		//		Vector2 heading = target - position;
		//		if (heading.Y < 0f)
		//		{
		//			heading.Y *= -1f;
		//		}
		//		if (heading.Y < 20f)
		//		{
		//			heading.Y = 20f;
		//		}
		//		heading.Normalize();
		//		heading *= new Vector2(speedX, speedY).Length();
		//		speedX = heading.X;
		//		speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
		//		Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
		//	}
		//	return false;
		//}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddIngredient(ItemID.InfluxWaver, 1);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}