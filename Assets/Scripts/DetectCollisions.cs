using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Detect the collission between the player and the collectable

    private void GetCollectables()
    {
        Destroy(gameObject);
        Debug.Log($"Yey! You have got 1 collectable. You are getting closer to winnning!");
    }

}
