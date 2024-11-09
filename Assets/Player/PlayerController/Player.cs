using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5;
    
    public Rigidbody2D rb;
    public bool facingRight = false;



    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

    

        if (facingRight == true && horizontal < 0 ||
            facingRight == false && horizontal > 0)
        {
            Flip();
        }

        rb.velocity = new Vector2(horizontal, vertical) * speed;
    }


    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}