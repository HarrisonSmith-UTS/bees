using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float speed = 10;

    //Create objects to hold the values for player input
    public float xVal = 0f;
    public float zVal = 0f;

    //Create objects to hold collider objects
    public GameObject colliderL, colliderR, colliderU, colliderD;

    void Update ()
    {   
        /*
        Using Unity's input manager, we don't need to worry too much about
        coding specifically for controllers
        */
        /*
        If we were to add other control systems like keyboard and mouse,
        we don't have to do any more laborious coding and instead maybe 
        implement some simple value shifts
        */

        xVal = Input.GetAxis("Horizontal");
        zVal = Input.GetAxis("Vertical");

        //If colliding with a barrier, prevent movement in the direction of the barrier
        /*
        if (collideL && xVal < 0)
        {
            xVal = 0;
        }
        if (collideR && xVal > 0)
        {
            xVal = 0;
        }
        if (collideD && zVal < 0)
        {
            zVal = 0;
        }
        if (collideU && zVal > 0)
        {
            zVal = 0;
        }
        */
        //Move player
        transform.Translate(xVal * Time.deltaTime * speed, 0f, zVal * Time.deltaTime * speed, Space.World);
	}
}
