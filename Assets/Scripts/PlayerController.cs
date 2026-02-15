using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;
    public float jumpForce;
    public Transform visual;

    bool facingRight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
    }


    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); //right 1, left -1
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        if (moveInput > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveInput < 0 && facingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = visual.localScale;
        scaler.x *= -1f;
        visual.localScale = scaler;
    }
}
