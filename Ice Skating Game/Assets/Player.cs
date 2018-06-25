using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody2D RB;
    public float JumpSpeed;
    bool CanJump = true;
    public GameObject GameController;



    // Update is called once per frame
    void Update()
    { 
        if (Input.GetButtonDown("Jump") && CanJump == true)
        {
            RB.AddForce(Vector2.up * JumpSpeed);
            CanJump = false;
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
