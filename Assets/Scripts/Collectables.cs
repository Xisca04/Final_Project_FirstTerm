using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    // Aparition of the collectables
    
    // Limits of the collectables
    private float spawnRangeX = 201f;
    private float spawnRangeNegativeX= -58.5f;
    private float spawnRangeZ = 38;

    private Vector3 RandomSpawnPos()  // Random pos of the collectables
    {
        float randomX  = Random.Range(spawnRangeX, spawnRangeNegativeX);
        float randomZ = Random.Range(spawnRangeZ, -spawnRangeZ);
        return new Vector3(randomX, 1, randomZ);  // In the Y's axis is 1 because the collectable wouldn't be seen.
    }

    private void Start()
    {
       transform.position = RandomSpawnPos();
    }

}
