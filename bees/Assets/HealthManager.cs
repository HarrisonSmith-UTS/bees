using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float health;
    public float defenceModifier = 1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Update is called on a fixed basis
    void FixedUpdate()
    {
        if (health <= 0f)
        {
            //Death occurs, calls the 'Die' method on this object
            SendMessage("die");
        }
    }

    //public void die()
    //{
    //Should probably not implement here as it is specific to an object? E.g a bee would die but be disabled for re-instantiation later possibly
    //And a player would have other things they would set off like game over screen
    //}

    /// <summary>
    /// Call this when taking damage and supply the amount of damage dealt
    /// </summary>
    public void takeDamage(float damage)
    {
        //Decrements health by however much damage
        health -= damage * defenceModifier;
    }
}
