using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pew : MonoBehaviour {
    public float thrust;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.forward * thrust);
    }
}
