using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoneMove : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public Transform tr;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey((KeyCode.W)))
        {
            tr.Translate(transform.forward * thrust);
        }
        if (Input.GetKey((KeyCode.S)))
        {
            tr.Translate(-transform.forward * thrust);
        }
        if (Input.GetKey((KeyCode.D)))
        {
            tr.Translate(transform.right * thrust);
        }
        if (Input.GetKey((KeyCode.A)))
        {
            tr.Translate(-transform.right * thrust);
        }
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * thrust;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * thrust;
    }
}
