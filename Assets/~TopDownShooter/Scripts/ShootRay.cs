using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootRay : MonoBehaviour
{
    public float distance = 30f;
    public int kills = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hitInfo;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hitInfo, distance))
            {
                Debug.DrawLine(ray.origin, ray.GetPoint(30f), Color.blue);
                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    Debug.Log("Hit Enemy");
                    Destroy(hitInfo.transform.gameObject);
                    kills++;
                    
                }
            }
        }
        if(kills >= 30)
        {
            SceneManager.LoadScene(2);
        }
    }
    
}
