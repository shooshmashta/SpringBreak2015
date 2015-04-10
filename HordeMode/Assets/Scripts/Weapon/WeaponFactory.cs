using UnityEngine;
using System.Collections;

public static class WeaponFactory
{

	public static Weapon generateWeapon (int level, BlockTypes blockType)
	{
		Weapon weapon = null;

		switch (blockType) {
		case BlockTypes.Wall:
			Debug.LogError("ERROR: cannot create weapon for the wall blocktype", blockType);
			break;
		case BlockTypes.Regular:
			int fireRate = level;
			int damage = 1 + level / 2;
			int range = 3;
			weapon = new Weapon (range, damage, fireRate, 1);
			break;
		default:
			Debug.LogError("ERROR: blockType is undefined", blockType);
			break;
		}
		return weapon;
	}
}