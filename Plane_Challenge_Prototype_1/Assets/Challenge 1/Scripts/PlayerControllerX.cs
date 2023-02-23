using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    [SerializeField]
    private float forceAdded;
    Rigidbody body;
    


    // Start is called before the first frame update
    void Start()
    {
     body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        // move the plane forward at a constant rate
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);  

        if (Input.GetAxis("Vertical") == 1)
        {

            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") == -1)
        {

            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
        
        if (Input.GetAxis("Horizontal") == 1) { transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime); body.AddForce(0, 1 * forceAdded * Time.deltaTime, 0, ForceMode.Force); }
        else if (Input.GetAxis("Horizontal") == -1) { transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime); body.AddForce(0, 1 * forceAdded * Time.deltaTime, 0, ForceMode.Force); }


    }
}
