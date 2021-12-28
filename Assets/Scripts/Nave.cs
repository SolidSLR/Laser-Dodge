using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    //Declaración de variables
    private float speed = 5F;
    private byte shipLife = 3;
    private bool canDie = true;
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
        ComprobarContacto();
        //Movimiento básico de la nave
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, -90);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
    }


    private void ComprobarContacto()
    {
        LayerMask mask = LayerMask.GetMask("Balas");
        if (colisionador.IsTouchingLayers(mask))
        {
            shipLife--;
            canDie = false;
        }
    }

    
}
