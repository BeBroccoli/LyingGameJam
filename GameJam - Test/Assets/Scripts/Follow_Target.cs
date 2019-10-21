using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Target : MonoBehaviour
{
    
    public float speed;
    private Transform player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Movement.insanity >= 25)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
