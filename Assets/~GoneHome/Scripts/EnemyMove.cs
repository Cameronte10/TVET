using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public float thrust;
    public Rigidbody rb;
    public Transform tr;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
    rb.AddForce(transform.forward * thrust);
}
}
