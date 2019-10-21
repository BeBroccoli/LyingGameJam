using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public string tagName;
    public static bool isDead = false;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == tagName)
        {
            Debug.Log(other.gameObject.name);
            Destroy(this.gameObject);
            isDead = true;
        }
    }
}
