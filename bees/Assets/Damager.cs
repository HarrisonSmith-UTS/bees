using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    public float damageAmount = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnCollisionEnter(Collision collision)
    {
        //How to decide how much damage to deal?
        //Should be 'hard coded' to the component (e.g. a certain weapon does a certain amount of damage each hit). 
        //damageAmount may be modified by another component if e.g. a damage boost thing happens
        collision.gameObject.SendMessage("takeDamage", damageAmount, SendMessageOptions.DontRequireReceiver);
    }
}
