using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {	
	}
	
	// Update is called once per frame
	void Update ()
    {
       

        float rx = Input.GetAxis("Right_Horizontal");
        float ry = Input.GetAxis("Right_Vertical");

        float angle = Mathf.Atan2(rx, ry);

        transform.rotation = Quaternion.EulerAngles(0,angle,0);

    }
}
