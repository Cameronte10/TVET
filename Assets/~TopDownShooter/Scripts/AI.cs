using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI : MonoBehaviour {
    GameObject player; //gets player
    public Transform target; //gets players transform
	public float speed; //gets speed
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //Gets the player
        target = player.GetComponent<Transform>(); //Gets the players transform
    }
    void Update()
    {
       
        if (target != null)
        {
            transform.LookAt(target); 
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
