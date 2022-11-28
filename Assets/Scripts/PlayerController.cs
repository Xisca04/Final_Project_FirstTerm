using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement of the player on the plataform

    public float speed = 22f;
    public float turnSpeed = 11f;
    private float horizontalInput;
    private float verticalInput;
    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");  // Lateral movement
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput); 
        
        verticalInput = Input.GetAxis("Vertical");  // Forward and backward movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput); 
    }
}
