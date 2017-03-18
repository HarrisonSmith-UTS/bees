using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

//bee prefab goes here
    public GameObject beePrefab;

//variables that are used to determine the rate of bee spawning
    float iteratorTimer = 0;
    float spawnIterator = 0;
    public float spawnRate = 0;

//position variables to determine where the bees will spawn within a spawn zone
    float xPos;
    float yPos;

    float spawnTimer = 0;
    
    private void Update()
    {
        //reset spawn timer
        float spawnTimer = Time.deltaTime;

        //increment the spawnIterator to ramp up bee spawn rate over time
        iteratorTimer += Time.deltaTime;
        if (iteratorTimer >= 10)
        {
            iteratorTimer = 0;
            spawnIterator += 1;
        }
        spawnRate = 1 + (2 * spawnIterator);

        if (spawnTimer >= (1 / spawnRate))
        {
            spawnTimer = 0;
            Spawn();
        }
    }

	void Spawn()
    {
        //Pick a spawn range around the bounds of the map
        switch (Random.Range(0, 4))
        {
            case 0:
                xPos = (Random.Range(-9, -11));
                yPos = (Random.Range(-9, 9));
                break;
            case 1:
                xPos = (Random.Range(-9, 9));
                yPos = (Random.Range(7, 9));
                break;
            case 2:
                xPos = (Random.Range(9, 11));
                yPos = (Random.Range(-9, 9));
                break;
            case 3:
                xPos = (Random.Range(-9, 9));
                yPos = (Random.Range(-7, -7));
                break;
        }
        //Setting vector3 location for spawn
        Vector3 spawnPos = new Vector3(xPos, 0.5f, yPos);
        //create bee at the random position
        Instantiate(beePrefab, spawnPos, Quaternion.identity);
    }
}
