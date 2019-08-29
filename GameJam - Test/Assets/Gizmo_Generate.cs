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
        Gizmos.DrawSphere(transform.position + center,size);
      
    }

    void SpawnNewEnemy()
    {
        Vector3 pos = center + new Vector3(Random.Range(transform.position.x + -size + (float)0.5, transform.position.x + size + (float)-0.5), Random.Range(transform.position.y + -size, transform.position.y + -size));

        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }
}
