using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {
	private float timer = 0;
	public float delay;
    void OnCollisionEnter(Collision collision)
    {
		timer++;
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
		if(timer >= delay)
		{
			Destroy(this.gameObject);
		}
    }
}
