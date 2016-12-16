using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float speed = 10;
    
    
	void Start ()
    {	
	}
	
	
	void Update ()
    {

        //Create objects to hold the values for player input
        /*
        Using Unity's input manager, we don't need to worry too much about
        coding specifically for controllers
        */
        /*
        If we were to add other control systems like keyboard and mouse,
        we don't have to do any more laborious coding and instead maybe 
        implement some simple value shifts
        */

        float xVal = Input.GetAxis("Horizontal");
        float zVal = Input.GetAxis("Vertical");

            transform.Translate(xVal * Time.deltaTime * speed, 0f, zVal * Time.deltaTime * speed, Space.World);
	}
}
