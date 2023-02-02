using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject enemyPrefab;
	public float respawnTime = 1.0f;
	
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyWave());
    }
	
	private void spawnEnemy()
	{
		GameObject a = Instantiate(enemyPrefab) as GameObject;
		a.transform.position = new Vector2(Random.Range(-7, 8), 11);
	}
	
	IEnumerator enemyWave()
	{
		while(true)
		{
			yield return new WaitForSeconds(respawnTime);
			spawnEnemy();
		}
	}

  private void LateUpdate()
  {
	  if(respawnTime > 0.1f)
	  {
	  respawnTime = respawnTime - 0.00001f;
	  }
  }
}
