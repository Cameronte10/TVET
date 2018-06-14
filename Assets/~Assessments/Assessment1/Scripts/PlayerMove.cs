using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    private Camera cam;

    private Vector3 moveInput;
    private Vector3 moveVelocity;
    // Use this for initialization
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        cam = FindObjectOfType<Camera>();
    }

    private void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        //Get input controls
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * speed; //Move

        //set up ray for following mouse
        Ray cameraRay = cam.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.up, Vector3.zero);
        float length;

        if (ground.Raycast(cameraRay, out length))
        {
            //make player look at mouse
            Vector3 look = cameraRay.GetPoint(length);
            Debug.DrawLine(cameraRay.origin, look, Color.blue);
            transform.LookAt(new Vector3(look.x, transform.position.y, look.z));
        }
    }
}
