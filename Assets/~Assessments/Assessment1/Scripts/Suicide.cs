using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicide : MonoBehaviour {
    public int timer = 0;
    //simple script that self destructs after certain time
    void Update () {
        timer++;
		if(timer >= 300)
        {
            Destroy(gameObject);
        }
	}
}
