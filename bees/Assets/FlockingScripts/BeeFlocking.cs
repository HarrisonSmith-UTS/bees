using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeFlocking : MonoBehaviour

{
/*
    private GameObject Controller;
    private bool inited = false;
    private float velocity;
    private GameObject chasee;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine("BeeSteering");
	}

    IEnumerator BeeSteering()
    {
        while (true)
        {
            if (inited)
            {
                rigidbody.velocity = rigidbody.velocity + Calc() * Time.deltaTime;

                rigidbody.velocity = rigidbody.velocity.normalised * velocity;
            }
        }
        float waitTime = 0.5f;
        yield return new WaitForSeconds(waitTime);
    }

    private Vector3 Calc ()
    {
        Vector3 position = new Vector3(0, 0, 0);

        position.Normalize();
        BeeController beeController = Controller.GetComponent<BeeController>();
        Vector3 flockCenter = BeeSteering Controller.flockCenter;
        Vector3 flockVelocity = beeController.flockVelocity;
        Vector3 follow = chasee.transform.localPosition;

        flockCenter = flockCenter - transform.localPosition;
        flockVelocity = flockVelocity - rigidbody.velocity;
        follow = follow - transform.localPosition;

        return (flockCenter + flockVelocity + follow * 2 + velocity);
    }

    public void SetController (GameObject theController)
    {
        Controller = theController;
        BeeController beeController = Controller.GetComponent<BeeController>();
        velocity = beeController.velocity;
        chasee = beeController.chasee;
        inited = true;
    }
	// Update is called once per frame
	void Update ()
    {
	}
    */
}
