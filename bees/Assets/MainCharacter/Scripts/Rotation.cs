using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {	
	}
    public float deadzone = 0.025f;
    // Update is called once per frame
    void Update ()
    {
       

        float rx = Input.GetAxis("Right_Horizontal");
        float ry = Input.GetAxis("Right_Vertical");

        float angle = Mathf.Atan2(rx, ry);
        angle = angle * Mathf.Rad2Deg;

        float distance = Mathf.Sqrt(Mathf.Pow(rx, 2f)+ Mathf.Pow(ry, 2f));


        if (distance > deadzone)
        {
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }
    }
}
