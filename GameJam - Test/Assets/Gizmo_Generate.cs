using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmo_Generate : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float size;
    public Vector3 center;

    // Update is called once per frame
    void Update()
    {
        if (Enemy_Spawn.isDead == true)
        {
            Debug.Log("Something actually happend!!!!");
            SpawnNewEnemy();
            Enemy_Spawn.isDead = false;
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(center,size);
      
    }

    void SpawnNewEnemy()
    {
        Vector3 pos = center + new Vector3(Random.Range((float)-2.5, (float)2.5), Random.Range(-3, -3));

        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }
}
