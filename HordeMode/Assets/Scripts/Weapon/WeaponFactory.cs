using UnityEngine;
using System.Collections;

public class WeaponFactory : MonoBehaviour
{
	public WeaponFactory ()
	{
	}

	public Weapon generateWeapon(int level, BlockTypes blockType)
	{
		Weapon weapon = null;
		switch (blockType) {
		case BlockTypes.Wall:
			break;
		case BlockTypes.Regular:
			int fireRate = level;
			int damage = 1 + level / 2;
			int range = 3;
			weapon = new Weapon (range, damage, fireRate, 1);
			break;
		}
		return weapon;
	}
}