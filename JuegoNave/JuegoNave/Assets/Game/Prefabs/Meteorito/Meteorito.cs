using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorito : MonoBehaviour
{

    public Transform meteorito_sprite;

    //public float gravity = 1f;
    public Rigidbody2D rb;

    private Vector2 move;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.gravityScale = gravity;
    }

    private void FixedUpdate()
    {

        meteorito_sprite.Rotate(new Vector3(0f,0f,Time.deltaTime * 200f));

        if (transform.position.y < -15f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            //Aqui explota el meteoro
        }
    }
}
