﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchMeNayNay : MonoBehaviour
{
    private Transform cursor;
    public static Quaternion quaternion;
    public GameObject player;
    public GameObject enemy;

    private void Start()
    {
        cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<Transform>();
        quaternion = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        quaternion = transform.rotation;

        transform.LookAt(cursor);

        transform.position = player.transform.position;
    }
    
}
