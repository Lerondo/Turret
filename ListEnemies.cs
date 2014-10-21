/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyBehavior : MonoBehaviour, IComparable<EnemyBehavior> {

	public int sort;
	private DateTime TimeAdded;
	public int CompareTo(EnemyBehavior other)
	{
		if(other.sort == this.sort)
		{
			return this.TimeAdded.CompareTo(other.TimeAdded);
		}
		return other.sort.CompareTo(this.sort);
	}

	private List<EnemyBehavior> enemyScripts = new List<EnemyBehavior>();
	enemyScripts.Sort();

	void OnTriggerEnter(Collider other) 
	{
		EnemyBehavior enemyScript = other.GetComponent<EnemyBehavior> ();
		if(other.transform.tag == "Enemy")
		{
			enemyScripts.Add(enemyScript);
			enemyScripts.Sort();
		}
	}

	void Update()
	{
		if(enemyScripts.Count != 0)
		{
			for(int i = 0; i < enemyScripts.Count; i++)
			{
				if(enemyScripts[0].thisTransform)
				{
					//shoot enemy[0].thisTransform;
				}
			}
		}
	}
}*/
