using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Destroy the collectable and count it

    public int Counter;

    private void GetCollectables(Collider other) // Destroy the collectable
    {
        Destroy(other.gameObject);
        Counter++;
        Debug.Log($"Yey! You have got 1 more collectable. There are {30 - Counter} more to collect!");

        if(Counter == 30)  // Detect if the player has won or not
        {
            Debug.Log($"You are the best, you have won!");
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Collectable"))
        {
            GetCollectables(other);
        }
    }

    
}
