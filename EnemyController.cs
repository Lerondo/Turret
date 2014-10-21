using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed = 0.5f;

	void Update () 
	{
		if(Input.GetKey(KeyCode.W))
		{
			this.transform.Translate (Vector3.right * speed);
		}
		if(Input.GetKey(KeyCode.D))
		{
			this.transform.Translate (Vector3.back * speed);
		}
		if(Input.GetKey(KeyCode.A))
		{
			this.transform.Translate (Vector3.forward * speed);
		}
		if(Input.GetKey(KeyCode.S))
		{
			this.transform.Translate (Vector3.left * speed);
		}
	}
}
