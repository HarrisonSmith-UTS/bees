using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public float rotationalSpeed = 10;
    float xRotVal;
    float yRotVal;

	// Use this for initialization
	void Start ()
    {	
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*float xInputVal = Input.GetAxis("Horizontal");
        float yInputVal = Input.GetAxis("Vertical");

        if (yInputVal != 0)
        {
            yRotVal = 90 * yInputVal;
            print(yRotVal);
        }
   
        if (xInputVal != 0)
        {
            //xRotVal = 90 * xInputVal;
            xRotVal = xInputVal;
            transform.Rotate(Vector3.up, xRotVal);
            print(xRotVal);
        }*/

        /*
        float leftRot = Input.GetAxis("rHor");
        float rightRot = Input.GetAxis("rVert");

        if (leftRot != 0)
        {
            transform.Rotate(Vector3.up, leftRot * rotationalSpeed);
        }
        if (rightRot != 0)
        {
            transform.Rotate(Vector3.up, rightRot * rotationalSpeed);
        }
        */


        float leftRot = Input.GetAxis("rHor") * -1;
        float rightRot = Input.GetAxis("rVert") * -1;

        //print(leftRot);
        //print(rightRot);

        if (leftRot != 0
            &&
            rightRot != 0)

        {
            float radians = Mathf.Atan2(leftRot, rightRot);
            float rotate = radians * (180 / Mathf.PI);
            //print(radians);
            transform.rotation = Quaternion.Euler(0, rotate, 0);
        }

    }
}
