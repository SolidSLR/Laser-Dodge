using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    private float speed = 2F;
    private float actualspeed;
    Animator animator;
    private Rigidbody2D rb;
    private Collider2D collider;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }
    }
}
