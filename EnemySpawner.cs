using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject Enemy;
	public Transform spawnPointEnemy;
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.M))
		{
			Instantiate (Enemy, spawnPointEnemy.position, spawnPointEnemy.rotation);
		}
	}
}
