using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerTest : MonoBehaviour
{
    public float speed;
    public float move;
    public Animator animator; // refrenece to animator
    public CharacterController2D controller;

    // bools
    bool jump;
    bool crouch;
    bool fall;
    bool isGrounded;

    // reference for rigidbody
    Rigidbody2D rb;

    // ceiling and ground check
    public Transform groundCheck;
    public Transform ceilingCheck;

    // Jump (range) variables
    [Range(1, 10)]
    public float jumpVelocity;
    public float jumpHeight;


    // comment each step before writing it.



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        // "Speed" is the name of the new condition made in the animation editor
        animator.SetFloat("Speed", Mathf.Abs(move));
        // left and right movement
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        /* Jump */
        jumpHeight = Input.GetAxis("Jump");
        if (Input.GetButtonUp("Jump"))
        {
            // enhancing jump
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;

            jump = true;
            animator.SetBool("isJumping", true);

        } else if (Input.GetButtonDown("Jump"))
        {
            // user is no longer jumping
            jump = false;
            animator.SetBool("isJumping", false);
        }

        /* Crouch */
        if (Input.GetButtonDown("Crouch")) // down
        {
            crouch = true; // allowed to crouch if button is pressing down
        }
        else if (Input.GetButtonUp("Crouch")) // up
        {
            crouch = false; // not allowed to crouch if button isn't being pressed down
        }

        // trigger idle whenever the player touches the ground
        if (Input.GetButtonDown("")) // if player is no longer jumping
        {
            animator.SetBool("playerIsIdle", true);
        }
    }


    public void GroundCheck()
    {
        // if user touches ground, return to idle
       animator.SetBool("isGrounded", true);
    }

    public void OnLanding()
    {
        if (!Input.GetButtonUp("Jump"))
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("playerIsIdle", true);
            // fall = true;
        }
    }
}
