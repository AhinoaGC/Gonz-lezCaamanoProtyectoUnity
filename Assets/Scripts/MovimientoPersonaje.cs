using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{

    public float velocidadCorrer = 4;
    public float velocidadSalto = 7;

    public float multiplicadorSalto = 0.5f;
    public float multiplicadorSaltoMenor = 1f;

    public Animator animator;

    Rigidbody2D rb;

    SpriteRenderer sr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = new Vector2(velocidadCorrer, rb.velocity.y);
            sr.flipX = false;
            animator.SetBool("Correr", true);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-velocidadCorrer, rb.velocity.y);
            sr.flipX = true;
            animator.SetBool("Correr", true);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            animator.SetBool("Correr", false);
        }

        if (Input.GetKey("space") && ComprobarSuelo.tocaSuelo)
        {
            rb.velocity = new Vector2(rb.velocity.x, velocidadSalto);
        }

        if (ComprobarSuelo.tocaSuelo == false)
        {
            animator.SetBool("Saltar", true);
            animator.SetBool("Correr", false);
        }
        if (ComprobarSuelo.tocaSuelo == true)
        {
            animator.SetBool("Saltar", false);
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (multiplicadorSalto) * Time.deltaTime;
        }else if (rb.velocity.y > 0 && !Input.GetKey("space"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (multiplicadorSaltoMenor) * Time.deltaTime;
        }

    }
}
