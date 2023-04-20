using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveX;
    public float moveY;

    public float speed;

    public Rigidbody rb;

    void Start()
    {
        
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(moveX * speed, 0, moveY * speed);
    }
}
