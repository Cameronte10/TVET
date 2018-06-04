using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed = 20;
	public float timer;
	public float timerMax;

    // Use this for initialization
    void Start()
    {
        

       

    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		if (Input.GetButton ("Fire1") && timer >= timerMax) {
			Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
			timer = 0;
				
		} 

}
}