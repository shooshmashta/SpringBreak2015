using UnityEngine;
using System.Collections;

public class OffenseBlock : AbstractBlock
{
	public GameObject bullet;
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
		GameObject enemy = findClosestEnemy ();
		if (enemy == null) {
			return;
		}

		Vector3 shotDirection = (enemy.transform.position - transform.position).normalized;
		Vector3 shotStart = new Vector3 (transform.position.x + 1.0f, transform.position.y, 0);
		Instantiate (bullet, shotStart, Quaternion.LookRotation (shotDirection));
	}

	GameObject findClosestEnemy ()
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		GameObject closestEnemy = null;
		float closestEnemyDistance = Mathf.Infinity;
		
		foreach (GameObject enemy in enemies) {
			Vector3 enemyPos = enemy.transform.position;
			float enemyDistance = (enemyPos - transform.position).sqrMagnitude;
			if (enemyDistance < closestEnemyDistance) {
				closestEnemy = enemy;
				closestEnemyDistance = enemyDistance;
			}
			
		}

		if (weapon.range > closestEnemyDistance) {
			return null;
		}

		return closestEnemy;
	}
}

