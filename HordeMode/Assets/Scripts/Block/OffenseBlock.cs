using UnityEngine;
using System.Collections;

public class OffenseBlock : AbstractBlock
{
	Weapon weapon;

	// Use this for initialization
	void Start ()
	{
		level = 1;
		health = level;
		weapon = WeaponFactory.generateWeapon (1, blockType);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (weapon.isReadyToFire ()) {
			Fire ();
		}
	}

	void Fire ()
	{

	}
}

