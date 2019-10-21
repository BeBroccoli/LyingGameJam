using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    private float rayCastMaxDistance = 100f;
    private Transform rayCastPos;
    private Transform player;
    private Vector2 direction;
    private Vector2 startPos;
    private Vector3 rayDirection;

    private void Start()
    {
        rayCastPos = GameObject.FindGameObjectWithTag("Finish").GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private RaycastHit2D CheckRaycast(Vector2 direction)
    {

        

        Debug.DrawRay(startPos, direction, Color.white);

        return Physics2D.Raycast(startPos, direction, rayCastMaxDistance);

    }

    private void Update()
    {
        transform.position = player.transform.position;
        RayPew();
        direction = new Vector2(rayCastPos.transform.position.x, rayCastPos.transform.position.y);
        startPos = new Vector2(transform.position.x, transform.position.y);

        

        
    }

    private void RayPew()
    {
        
        RaycastHit2D hit = CheckRaycast(direction);

        //if (hit.collider.name == "Enemy")
        //{
        //    Destroy(hit.collider.gameObject);
        //    Enemy_Spawn.isDead = true;
        //}

        if (hit.collider)
        { 
            Debug.Log("Hit the Gameobject = " + hit.collider.name);

            
        }
        else
        {
            
        }
       
    }
   
	
    

    

}
