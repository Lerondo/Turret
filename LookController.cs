using UnityEngine;
using System.Collections;

public class LookController : MonoBehaviour {

	public Transform objct;
	public GameObject target;
	public bool looking = false;
	public float smooth = 6;

	public GameObject Bullet;
	public Transform spawnPoint1;
	public Transform spawnPoint2;
	public Transform spawnPoint3;
	public Transform spawnPoint4;
	public Transform spawnPoint5;
	public Transform spawnPoint6;

	private int timer= 0;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			looking = true;
			target = other.gameObject;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == target) {
			looking = false; 
			target = null;
		}
	}

	void Update()
	{
		Debug.Log (target);
		if (looking == true) 
		{
			Shoot ();
		} 
		else 
		{
			looking = false;
			target = null;
		}
	}

	public void Shoot()
	{
		if (target != null) 
		{
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.transform.position - transform.position), Time.deltaTime * smooth);
			//transform.LookAt (objct);
			timer++;
			if (timer >= 19 && timer <= 21) 
			{
				Instantiate (Bullet, spawnPoint1.position, spawnPoint1.rotation);
			}
			if (timer >= 39 && timer <= 41) 
			{
				Instantiate (Bullet, spawnPoint2.position, spawnPoint2.rotation);
			}
			if (timer >= 59 && timer <= 61) 
			{
				Instantiate (Bullet, spawnPoint3.position, spawnPoint3.rotation);
			}
			if (timer >= 79 && timer <= 81) 
			{
				Instantiate (Bullet, spawnPoint4.position, spawnPoint4.rotation);
			}
			if (timer >= 99 && timer <= 101) 
			{
				Instantiate (Bullet, spawnPoint5.position, spawnPoint5.rotation);
			}
			if (timer >= 119 && timer <= 121) 
			{
				Instantiate (Bullet, spawnPoint6.position, spawnPoint6.rotation);
				timer = 0;
			}
		}
	}
}
