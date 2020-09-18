using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 20;
    private float turnSpeed = 100;

    private float horizontalInput;
    private float vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");
      vInput = Input.GetAxis("Vertical");

      //Move the vehicle forward bsed on vertical input
      transform.Translate(Vector3.forward * Time.deltaTime * vInput * speed);
      //Rotate the vehicle left and right based on horizontal input
      transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);  
    }
}
