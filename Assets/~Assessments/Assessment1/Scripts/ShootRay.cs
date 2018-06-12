using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootRay : MonoBehaviour
{
    public GameObject sound;
    public float distance = 30f; //Set length of Ray
    public int kills = 0; //Number of points
   // public AudioSource source;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawLine(ray.origin, ray.GetPoint(30f), Color.blue);
            if (Physics.Raycast(ray, out hitInfo, distance)) //shoots ray
            {
                //source.Play();
                Instantiate(sound, transform.position, transform.rotation);

                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    //Debug.Log("Hit Enemy");
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
