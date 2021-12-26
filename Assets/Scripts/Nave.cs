using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    //Declaración de variables
    private float speed = 5F;
    Animator animator;
    private Rigidbody2D rb;
    private Collider2D colisionador;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        colisionador = GetComponent<Collider2D>();
    }

    void Update()
    {

        //Movimiento básico de la nave
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
            //  transform.Rotate(0, 0, -90);
            //Esto puede ser una idea para rotarlo en el eje de la z, el problema
            // es que lo hace en cada frame, hay que conseguir que solo se haga una vez
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.left * -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipY = false;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipY = true;
        }
    }
}
