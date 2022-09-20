using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHigh = 5f;
    public bool isGrounded = false;
    bool facingRight = true;
    public Rigidbody2D rb;

    void Update()
    {
        Jump();
        /* Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
         transform.position += movement * Time.deltaTime * moveSpeed; */
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

        if(move > 0 && !facingRight)
        {
            Flip();
        }
        else if(move > 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
        
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true || Input.GetKeyDown("w") && isGrounded == true || Input.GetKeyDown("up") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHigh), ForceMode2D.Impulse);
        }

    }
}
