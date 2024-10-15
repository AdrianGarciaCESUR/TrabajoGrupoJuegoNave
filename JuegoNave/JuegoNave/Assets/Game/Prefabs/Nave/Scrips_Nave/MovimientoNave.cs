using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    float move;
    Vector2 starPosition;


    void Start()
    {
        starPosition = transform.position;
    }


    void Update()
    {
            move = Input.GetAxisRaw("Horizontal_suave");
            rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
    }
    public void Reset()
    {
        transform.position = starPosition;
    }
}
