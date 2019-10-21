using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collsion : MonoBehaviour
{
    public static bool interacting;
    public bool open = false;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == ("Player") && Input.GetKeyDown(KeyCode.E))
        {
            open = true;
        }
        else
        {
            open = false;
        }

    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == ("Player") && Input.GetKeyDown(KeyCode.E))
        {
            open = true;
        }
        else
        {
            open = false;
        }

    }

}
