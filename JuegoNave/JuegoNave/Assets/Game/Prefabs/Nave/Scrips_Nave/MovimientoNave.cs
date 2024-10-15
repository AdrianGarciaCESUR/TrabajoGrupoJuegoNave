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
            move = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(Time.deltaTime * (move * speed), rb.velocity.y );
            rb.AddForce(Vector2.right);
    }
    public void Reset()
    {
        transform.position = starPosition;
    }
}
