using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchMeNayNay : MonoBehaviour
{
    public bool isSprite = false;
    private Transform cursor;


    private void Start()
    {
        cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") + (Input.GetAxis("Mouse Y"));
        float mouseY = Input.GetAxis("Mouse Y") + (Input.GetAxis("Mouse X"));


        transform.LookAt(cursor);

        if (isSprite == true)
        {
            if (true)
            {

            }
        }
    }
    
}
