using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    //Destroy the collectable and count it

    private void GetCollectables(Collider other) //Destroy the collectable
    {
        Destroy(other.gameObject);
        Debug.Log($"Yey! You have got 1 collectable. You are getting closer to winnning!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Collectable"))
        {
            GetCollectables(other);
        }
    }
}
