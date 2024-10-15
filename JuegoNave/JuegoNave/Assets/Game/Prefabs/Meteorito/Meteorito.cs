using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorito : MonoBehaviour
{

    public float speed = 1f;
    public Rigidbody2D rb;

    private Vector2 move;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        move.y = speed * Time.deltaTime;
        rb.velocity = move;
    }




}
