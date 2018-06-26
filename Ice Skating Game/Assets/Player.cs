using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody2D RB;
    public float JumpSpeed;
    bool CanJump = true;
    public GameObject GameController;
    public Animator Anim;
    public float PlayerSpeed;

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetButtonDown("Jump") && CanJump == true)
        {
            RB.AddForce(Vector2.up * JumpSpeed);
            CanJump = false;
        }

        // Tricks.
        if (Input.GetKeyDown(KeyCode.A))
        {

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

        }
        else if (Input.GetKeyDown(KeyCode.W))
        {

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {

        }
        else if (Input.GetKeyDown(KeyCode.A) && CanJump == false)
        {

        }
        else if (Input.GetKeyDown(KeyCode.W) && CanJump == false)
        {

        }
        else if (Input.GetKeyDown(KeyCode.D) && CanJump == false)
        {

        }
        else if (Input.GetKeyDown(KeyCode.S) && CanJump == false)
        {

        }

        //Left and right movement.
        if (Input.GetKey(KeyCode.Q))
        {
            RB.AddForce(-Vector2.right * PlayerSpeed);
        }
        if (Input.GetKey(KeyCode.E))
        {
            RB.AddForce(Vector2.right * PlayerSpeed);
        }


    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (RB.velocity.y == 0)
        {
            CanJump = true;
        }
    }
}
