using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2d;

    Vector2 movement;

    Rigidbody2D rb;

    public float jumpForce;
    bool jump = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");

        rb2d.velocity = movement.normalized * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {

           jump = true

        }

    }
}
