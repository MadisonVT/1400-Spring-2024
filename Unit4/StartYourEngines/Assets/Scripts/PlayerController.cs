using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves car side to side based on input
        horizontalInput = Input.GetAxis("Horizontal");
        // Moves car forward based on input
        forwardInput = Input.GetAxis("Vertical");
        // Turns front of car when turning for smooth movement
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        // Moves the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    }
}
