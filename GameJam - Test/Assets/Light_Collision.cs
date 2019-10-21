using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Collision : MonoBehaviour
{
    private Transform cursor;
    public GameObject player;
    

    // Start is called before the first frame update
    private void Start()
    {
        cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        transform.up = cursor.transform.position;
        

        
    }
    

    
}
