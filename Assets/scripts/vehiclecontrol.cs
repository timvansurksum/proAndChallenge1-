using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehiclecontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float horizontalInput;
    private float forwardInput;
    private float turnSpeed = 25f;
    private float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
       
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //turn the vehicle
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * 50);
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput * 5);
       
    }
}
