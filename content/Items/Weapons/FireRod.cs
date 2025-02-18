﻿using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace TheLegendofTerra.Content.Items.Weapons
{
	public class FireRod : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is an example magic weapon");
		}

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Magic; // Makes the damage register as magic. If your item does not have any damage type, it becomes true damage (which means that damage scalars will not affect it). Be sure to have a damage type.
			Item.width = 34;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Shoot; // Makes the player use a 'Shoot' use style for the Item.
			Item.noMelee = true; // Makes the item not do damage with it's melee hitbox.
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.Flames; // Shoot a black bolt, also known as the projectile shot from the onyx blaster.
			Item.shootSpeed = 7; // How fast the item shoots the projectile.
			Item.crit = 32; // The percent chance at hitting an enemy with a crit, plus the default amount of 4.
			Item.mana = 11; // This is how much mana the item uses.
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.DirtBlock)
				.Register();
		}
	}
}

