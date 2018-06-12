using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicide : MonoBehaviour {
    public int timer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
		if(timer >= 300)
        {
            Destroy(gameObject);
        }
	}
}
