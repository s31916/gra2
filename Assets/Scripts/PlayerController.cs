using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed = 5;
    public float runSpeed = 20;
    public float jumpforce = 3000;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float moveInput = Input.GetAxis("Horizontal");
        //Debug.Log($"Input value: {moveInput}");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(new Vector2(0, jumpforce));
            rb.AddForce(Vector2.up * jumpforce);
        }
    }
}
