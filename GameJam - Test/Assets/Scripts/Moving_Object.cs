using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Object : MonoBehaviour
{
    public static bool drive = false;
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (drive == true)
        {
            Debug.Log("Works");
            transform.Translate(0, -speed, 0);
        }


        if (rb.velocity.y <= -10)
        {
            Destroy(this);
        }
    }
}
