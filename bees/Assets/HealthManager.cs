using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float health;
    public float defenceModifier = 1f;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    //Update is called on a fixed basis
    void FixedUpdate()
    {
        if (health <= 0f)
        {
            //Death occurs, calls the 'Die' method on this object
            SendMessage("Die");
        }
    }

    /// <summary>
    /// Call this when taking damage
    /// </summary>
    void TakeDamage()
    {
        //Decrements health by a default amount of damage (1f)
        TakeDamage(1f);
    }

    /// <summary>
    /// Call this when taking damage and supply the amount of damage dealt
    /// </summary>
    void TakeDamage(float damage)
    {
        //Decrements health by however much damage
        health -= damage * defenceModifier;
    }
}
