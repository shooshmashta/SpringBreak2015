using UnityEngine;
using System.Collections;

public class Weapon
{
	int range;
	int fireRate;
	int damage;
	int numberOfShotsPerVolley;
	
	public Weapon (int range, int damage, int fireRate, int numberOfShotsPerVolley)
	{
		this.range = range;
		this.fireRate = fireRate;
		this.damage = damage;
		this.numberOfShotsPerVolley = numberOfShotsPerVolley;
	}
}