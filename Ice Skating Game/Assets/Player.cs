using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody2D RB;
    public float JumpSpeed;
    bool CanJump = true;
    public GameObject GameController;
    public Animator Anim;


    // Update is called once per frame
    void Update()
    { 
        if (Input.GetButtonDown("Jump") && CanJump == true)
        {
            RB.AddForce(Vector2.up * JumpSpeed);
            CanJump = false;
        }
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
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (RB.velocity.y == 0)
        {
            CanJump = true;
        }
    }
}
