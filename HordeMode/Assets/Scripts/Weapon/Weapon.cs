using UnityEngine;
using System.Collections;

public class Weapon
{
	int range;
	int damage;
	int shotsPerVolley;
	float maxFireRateIntervalSeconds;
	float currentFireRateIntervalSeconds;
	
	public Weapon (int range, int damage, float maxFireRateIntervalSeconds, int shotsPerVolley)
	{
		this.range = range;
		this.damage = damage;
		this.shotsPerVolley = shotsPerVolley;

		this.maxFireRateIntervalSeconds = maxFireRateIntervalSeconds;
		this.currentFireRateIntervalSeconds = maxFireRateIntervalSeconds;
	}

	public bool isReadyToFire ()
	{
		if (currentFireRateIntervalSeconds > 0.0f) {
			currentFireRateIntervalSeconds -= Time.deltaTime;
			return false;
		}

		currentFireRateIntervalSeconds = maxFireRateIntervalSeconds;
		return true;

	}
}