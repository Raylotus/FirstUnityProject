using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Animator animator;
    private string CurentaAnim;
    public Rigidbody2D Rigidbody2D;
    private Vector2 moveimput;



    private void Start()
    {
        animator = GetComponent<Animator>();
    }



    void Update()
    {
        
        Move();
    }

    void Move()
    {
        moveimput.x = Input.GetAxisRaw("Horizontal");
        moveimput.y = Input.GetAxisRaw("Vertical");

        moveimput.Normalize();

        Rigidbody2D.velocity = moveimput * moveSpeed;

        if (moveimput.x == 0 && moveimput.y == 0)
        {
            ChangeAnimation("idle1");
        }

        if (moveimput.x == 0 && moveimput.y == 1)
        {
            ChangeAnimation("WalkUp");
        }
        if (moveimput.x == 0 && moveimput.y == -1)
        {
            ChangeAnimation("WalkDown");
        }
        if (moveimput.x == 1 && moveimput.y == 0)
        {
            ChangeAnimation("WalkRight");
        }
        if (moveimput.x == -1 && moveimput.y == 0)
        {
            ChangeAnimation("WalkLeft");
        }
    }

    

    void ChangeAnimation(string anim)
    {
        if (CurentaAnim == anim) return;

        animator.Play(anim);
        CurentaAnim = anim;
    }





}
/*   if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
            animator.Play("WalkUp");

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }
        else { animator.Play("idle1"); } */