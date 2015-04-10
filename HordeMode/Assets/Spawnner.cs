using UnityEngine;
using System.Collections;

public class Spawnner : MonoBehaviour
{
    public GameObject enemy;

    public int currLevel = 1;
    public int spawnCount;

    public float spawnRate;
    public float spawnTimer;
    public float levelTimer;
    public float nextLevelTimer;

    private bool nextLevel = false;
    void Start()
    {
        spawnCount = 1;
        spawnRate = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!nextLevel)
        {
            //check to see how many enemies are left
            GameObject[] baddies = GameObject.FindGameObjectsWithTag("Enemy");
            //if there are none left, start timer for next level
            if (baddies.Length <= 0)
            {
                //start timer for next level
                levelTimer = 30.0f;
                nextLevel = true;

            }
            //are they still spawning?
            if(spawnCount > 0)
            {
                //call spawn function
                SpawnEnemy();
            }
        }
        else
        {
            //check the timer
            if(levelTimer > 0.0f)
            {
                levelTimer -= Time.deltaTime;
            }
            else
            {
                currLevel++;
                nextLevel = false;
                spawnCount = currLevel * 2;
            }

        }
    }
    
    //check if the spawn timer is ready, if so, instantiate
    public void SpawnEnemy()
    {
        if (spawnTimer > 0.0f)
        {
            //increase the timer
            spawnTimer -= Time.deltaTime;

        }
        else
        {
            //spawn the bastard
            Instantiate(enemy, gameObject.GetComponent<Rigidbody>().position, gameObject.GetComponent<Rigidbody>().rotation);
            spawnTimer = spawnRate;
            spawnCount--;
        }
    }



}
