using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float bulletSpeed = 5f;
	private int timer = 0;

	void Update () 
	{
		this.transform.Translate (Vector3.up * bulletSpeed);
		timer ++;
		if (timer >= 70) 
		{
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	}
}
