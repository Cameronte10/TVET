using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRay : MonoBehaviour
{
    public float distance = 30f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            RaycastHit hitInfo;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hitInfo, distance))
            {
                Debug.DrawLine(ray.origin, ray.GetPoint(30f), Color.blue);
                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    Debug.Log("Hit Enemy");

                    //Destroy(hitInfo.transform.gameObject);
                }
            }
        }
    }
    
}
