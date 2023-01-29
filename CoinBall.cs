using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBall : MonoBehaviour
{
    /*
    // Player Movement
    public CharacterController2D controller; 
    public float runSpeed = 40f; 
    public float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
 

    // Health system
    public int maxHealth = 100;
    public int currentHealth;

   // public HealthBar healthBar;



    void Start()
    {
        currentHealth = maxHealth;
    }


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
            

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(15);
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }


    void FixedUpdate()
    {
        // Apply input to character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    */
}

