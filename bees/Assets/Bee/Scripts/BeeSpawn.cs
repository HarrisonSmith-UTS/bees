using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeSpawn: MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
    }
    float iteratorTimer = 0;
    float spawnIterator = 0;
    public float spawnRate = 0;

    void FixedUpdate()
    {
        iteratorTimer += Time.deltaTime;
        if(iteratorTimer >= 30)
        {
            iteratorTimer = 0;
            spawnIterator += 1;
        }

        spawnRate = 5 + (2 * spawnIterator);
    }
}
