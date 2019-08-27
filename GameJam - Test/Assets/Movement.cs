using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public static float speed = 5;
    private float moveInputX;
    private float moveInputY;
    private bool isRight;
    public static int insanity = 0;
    private bool isInDarkness = true;
    private float timeBetweenGain = 0;
    private float cooldown = 1;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    

    void Update()
    {
        if (Time.time > timeBetweenGain)
        {
            if (isInDarkness == true)
            {
                insanity += 1;
                timeBetweenGain = Time.time + cooldown;
            }
        }

        moveInputX = Input.GetAxisRaw("Horizontal");
        moveInputY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(moveInputX * speed, moveInputY * speed);
    }
}
