using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D _rb;
    float _move;
    Vector2 starPosition;


    void Start()
    {
        starPosition = transform.position;
    }


    void Update()
    {
            _move = Input.GetAxisRaw("Horizontal_suave");
            _rb.velocity = new Vector2(_move * speed * Time.deltaTime, _rb.velocity.y);
    }
    public void Reset()
    {
        transform.position = starPosition;
    }
}
