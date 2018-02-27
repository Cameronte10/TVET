using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float thrust;
    public Rigidbody rb;
    public Transform tr;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey((KeyCode.W)))
        {
            rb.AddForce(transform.forward * thrust);
        }
        if (Input.GetKey((KeyCode.S)))
        {
            rb.AddForce(-transform.forward * thrust);
        }
        if (Input.GetKey((KeyCode.D)))
        {
            rb.AddForce(transform.right * thrust);
        }
        if (Input.GetKey((KeyCode.A)))
        {
            rb.AddForce(-transform.right * thrust);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
            transform.position = new Vector3(0, 0, 0);
        }
    
}
