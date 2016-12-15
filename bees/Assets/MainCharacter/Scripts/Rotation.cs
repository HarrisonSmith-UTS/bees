using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public float rotationalSpeed;
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

        bool leftRot = Input.GetButton("Fire1");
        bool rightRot = Input.GetButton("Fire2");

        if (leftRot)
        {
            transform.Rotate(Vector3.up, -rotationalSpeed);
        }
        if (rightRot)
        {
            transform.Rotate(Vector3.up, rotationalSpeed);
        }
    }
}
