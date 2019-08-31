using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Push : MonoBehaviour
{
    public string tagName;
    public GameObject door;
    private float speed = Movement.speed;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == tagName)
        {
            Debug.Log("Works... i guess...");
            door.transform.Rotate(0, 2 * speed, 0);
        }

    } 
}
