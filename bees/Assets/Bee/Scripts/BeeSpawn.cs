using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeSpawn: MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
    }
    float timer = 0;
    float spawnIterator = 0;
    public float spawnRate;

    public object beePrefab;
    bool disabled;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer >= 30)
        {
            timer = 0;
            spawnIterator += 1;
        }

        spawnRate = 5 + (2 * spawnIterator);


    }
}
