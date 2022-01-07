using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    //Declaración de variables
    private float speed = 5F;
    private int shipLife = 3;
    private bool canDie = true;

    //Podemos en vez de public hacerlo con un getter, hablarlo en la reunión
    public bool gameOver = false;
    Animator animator;
    private Rigidbody2D rb;
    private Collider2D colisionador;

    //Añadidas variables para controlar los efectos de impacto
    public AudioSource hit1;

    public AudioSource hit2;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        colisionador = GetComponent<Collider2D>();
    }

    void Update()
    {
        ComprobarGameOver();
        if (!gameOver)
        {
            if (canDie)
            {
                ComprobarContacto();
            }
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
    }


    private void ComprobarContacto()
    {
        LayerMask mask = LayerMask.GetMask("Balas");
        if (colisionador.IsTouchingLayers(mask))
        {
            shipLife--;
            int random2 = Random.Range(1, 3);
            if(random2==1){
                hit1.Play();
            }else if(random2==2){
                hit2.Play();
            }
            canDie = false;
            //Este valor se tiene que ajustar mas, hablarlo en la reunión
            Invoke("ResetCanDie", 1f);
        }
    }

    private void ResetCanDie()
    {
        canDie = true;
    }

    private void ComprobarGameOver()
    {
        if (shipLife <= 0)
        {
            gameOver = true;
        }

    }
}
