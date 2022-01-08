using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlls : MonoBehaviour{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        
        if (Input.GetMouseButton(0) && !Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(5, rb.velocity.y);
            
        }
        if (Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(4000, rb.velocity.x);
        }


        /*if (!Input.GetMouseButton(0) && !Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector3(0, rb.velocity.y);
        }*/
    }
}
