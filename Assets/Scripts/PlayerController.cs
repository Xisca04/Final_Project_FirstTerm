using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement of the player on the plataform

    private float speed = 22f;
    private float turnSpeed = 11f;
    private float horizontalInput;
    private float verticalInput;

    // Player's range x limit
    private float xLimit = 201f;
    private float xLimitNegative = -58.5f;

    // Player's range z limit
    private float zLimit = 38;
    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");  // Lateral movement
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput); 
        
        verticalInput = Input.GetAxis("Vertical");  // Forward and backward movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        PlayerInBounds();

        PlayerInBoundsZ();
    }

    private void PlayerInBounds() // Horizontal limits
    {
        Vector3 pos = transform.position;
        if (pos.x < xLimitNegative) 
        {
            transform.position = new Vector3(xLimitNegative, pos.y, pos.z);
        }

        if (pos.x > xLimit) 
        {
            transform.position = new Vector3(xLimit, pos.y, pos.z);
        }
    }

    private void PlayerInBoundsZ() // Horizontal limits
    {
        Vector3 pos = transform.position;
        if (pos.z < -zLimit)
        {
            transform.position = new Vector3(pos.x, pos.y, -zLimit);
        }

        if (pos.z > zLimit)
        {
            transform.position = new Vector3(pos.x, pos.y, zLimit);
        }
    }

}
