using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeller : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 100.0f;
    public float rotationSpeed = 500.0f;
    public class Propeller : MonoBehaviour
    {
        public float force = 100.0f;
        public float rotationSpeed = 500.0f;
      


    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // apply force to the Propeller
        rb.AddRelativeForce(Vector3.forward * force);
        
        //Rotate the propeller
        transform.Rotate(Vector3.forward , rotationSpeed * Time.fixedDeltaTime,Space.Self);
    }
}