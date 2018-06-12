using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detect : MonoBehaviour {
    private Collider2D[] col;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!Input.GetMouseButton(0))
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        ScreenMouseRay();
    }

    public void ScreenMouseRay()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 5;
        Vector2 v = Camera.main.ScreenToWorldPoint(mousePosition);
        col = Physics2D.OverlapPointAll(v);
        if(col.Length > 0)
        {
            foreach (Collider2D c in col)
            {
                if(c.CompareTag("Button"))
                {
                    c.GetComponent<SpriteRenderer>().color = Color.magenta;
                    SceneManager.LoadScene(1);
                }
            }
        }
    }
}
