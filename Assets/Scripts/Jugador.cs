using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public static Jugador instance;
    private Rigidbody2D rigidbody2d;

    float horizontal;

    public float jumpForce;
    public float speed;
    public float bounceForce;

    private bool grounded;

    public Animator animator;

    public Renderer fondo;

    public float knockBackLength, knockBackForce;
    private float knockBackCounter;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Foxy movement (axisraw = -1 for A and 1 for D)
        horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }
        else if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }

        animator.SetBool("running", horizontal != 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.7f, Color.red);

        if (Physics2D.Raycast(transform.position, Vector3.down, 0.7f))
        {
            grounded = true;
            animator.SetBool("estaSaltando", false);
        }
        else
        {
            grounded = false;
            animator.SetBool("estaSaltando", true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
            //animator.SetBool("estaSaltando", true);
        }
        else
        {
            //animator.SetBool("estaSaltando", false);
        }
    }

    // funcion para las fisicas del personaje (mover, saltar...)
    private void FixedUpdate()
    {
        if(horizontal < 0)
        {
            if(transform.position.x > -25.8f)
            {
                rigidbody2d.velocity = new Vector2(horizontal * speed, rigidbody2d.velocity.y);
            } else
            {
                rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
            }
        }

        if(horizontal == 0)
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
        }

        if(horizontal > 0)
        {
            rigidbody2d.velocity = new Vector2(horizontal * speed, rigidbody2d.velocity.y);
        }

        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(horizontal * 0.2f, 0) * Time.deltaTime;
    }

    private void Jump()
    {
        rigidbody2d.AddForce(Vector2.up * jumpForce);
        //animator.SetBool("estaSaltando", true);

    }

    public void KnockBack()
    {
        knockBackCounter = knockBackLength;
    }


    public void Bounce()
    {
        rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, bounceForce);
    }
}
