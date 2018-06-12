using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
    
	//Loads main scene 
	void Update () {
		if(Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(0);
        }
	}
}
