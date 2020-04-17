using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrueSwordOfPower
{
	public class TrueSwordOfPowerProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Name Here");
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.defense -= 30;
			target.AddBuff(BuffID.OnFire, 60);
			target.AddBuff(BuffID.Cursed, 60);
			target.AddBuff(BuffID.Ichor, 60);
			target.AddBuff(BuffID.Frostburn, 60);
			target.AddBuff(BuffID.Bleeding, 60);
		}

		public override void SetDefaults()
		{
			projectile.arrow = false;
			projectile.width = 16;
			projectile.height = 16;
			projectile.melee = true;
			projectile.aiStyle = 27;
			projectile.alpha = 255;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.light = 15;
			aiType = ProjectileID.TerraBeam;
		}

		// Additional hooks/methods here.
	}
}