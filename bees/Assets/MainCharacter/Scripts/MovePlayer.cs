using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    //Without making the player input smaller, they zip around too fast
    //This value divides the float value created from player input
    public int speedDivider = 5;
    

	void Start ()
    {
		
	}
	
	
	void Update ()
    {

        //If someone accidentally sets the divider to 0, reset it to 1
        if (speedDivider == 0)
        {
            speedDivider = 1;
        }

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

        float xVal = Input.GetAxis("Horizontal") / speedDivider;
        float zVal = Input.GetAxis("Vertical") / speedDivider;

        if (xVal != 0)
        {
            transform.Translate(xVal, 0f, 0f);
        }

        if (zVal != 0)
        {
            transform.Translate(0f, 0f, zVal);
        }

        float rot1 = Input.GetAxis("rVert");
	}
}
