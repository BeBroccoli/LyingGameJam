using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public static float speed = 5;
    private float moveInputX;
    private float moveInputY;
    private bool isRight;
    public static int insanity = 0;
    private bool isInDarkness = true;
    private float timeBetweenGain = 0;
    private float cooldown = 1;


    public bool isSprite = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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


        if (isSprite == true)
        {
            if (WatchMeNayNay.quaternion.y <= -90)
            {
                transform.Rotate(Vector3.up * 180);
            }
            else if (WatchMeNayNay.quaternion.y >= 90)
            {
                transform.Rotate(Vector3.up * 180);
            }
        }
    }
}
