using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 2;
    public float turnSpeed;

    public float horizontalInput;
    public float vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");
      vInput = Input.GetAxis("Vertical");

      //Move the vehicle forward
      transform.Translate(Vector3.forward * Time.deltaTime * vInput * speed);
      transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);  
    }
}
