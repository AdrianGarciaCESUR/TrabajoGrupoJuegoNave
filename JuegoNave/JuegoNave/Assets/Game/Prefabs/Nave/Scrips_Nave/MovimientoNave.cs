using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float speed = 3f;
    public float desaceleracion = 3f;
    public Rigidbody2D _rb;
    float _move;
    Vector2 starPosition;
    Vector2 fuerza;
    Vector2 fuerzaOpo;
    bool seMueve = false;

    void Start()
    {
        starPosition = transform.position;
    }


    void Update()
    {
        _move = Input.GetAxisRaw("Horizontal_suave");
        fuerza = new Vector2(_move * speed * Time.deltaTime, 0);//uhoiirewuhoi
        fuerzaOpo = new Vector2(1 * desaceleracion * Time.deltaTime, 0);

        _rb.AddForce(fuerza, ForceMode2D.Impulse);

        //_rb.velocity = new Vector2(_move * speed * Time.deltaTime, _rb.velocity.y);
        
        
       
    }
    public void Reset()
    {
        transform.position = starPosition;
    }
}
