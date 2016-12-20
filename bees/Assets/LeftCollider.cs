using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCollider : MonoBehaviour
{
    bool collideL = false;

    private void OnTriggerEnter(Collider other)
    {
        collideL = true;
    }

    private void OnTriggerExit(Collider other)
    {
        collideL = false;
    }
}
