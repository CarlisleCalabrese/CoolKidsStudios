using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour {
    public Rigidbody2D TrashBody;
    public float Speed;

	// Use this for initialization
	void Start () {
        TrashBody.AddForce(transform.right * Speed);
    }

    // Update is called once per frame
    void Update()
    {



        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (TrashBody.velocity.y == 0)
        {
            Destroy(gameObject);
        }
    }
}
