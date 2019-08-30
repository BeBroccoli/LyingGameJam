﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object_Colli : MonoBehaviour
{
    public string tagName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == tagName)
        {
            Moving_Object.drive = true;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == tagName)
        {
            Moving_Object.drive = true;
        }
    }
    
}
