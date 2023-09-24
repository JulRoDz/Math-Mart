using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float VelocidadMovimiento;
    [SerializeField] private Vector2 direccion;
    public float dirX, dirY;
    private Rigidbody2D rb2D;
    public SpriteRenderer spr;
    public Animator anim;
    

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        //Setear variables
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");
        direccion = new Vector2(dirX, dirY).normalized;

        //Girar personaje der y izq
        if (dirX > 0)
        {
            spr.flipX = false;
        }
        if (dirX < 0)
        {
            spr.flipX = true;
        }

        //Animaciones on/off

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("Movimiento", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Movimiento", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("Movimiento", true);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Movimiento", true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("Movimiento", true);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("Movimiento", true);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("Movimiento", true);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("Movimiento", true);
        }
        


        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("Movimiento", false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("Movimiento", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("Movimiento", false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Movimiento", false);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetBool("Movimiento", false);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("Movimiento", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("Movimiento", false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Movimiento", false);
        }



        if (Input.GetButtonDown("Fire1"))
        {
            Golpe();
        }
    }
    

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * VelocidadMovimiento * Time.fixedDeltaTime);
    }

    private void Golpe()
    {
        anim.SetTrigger("ataque");
    }
    
    }
