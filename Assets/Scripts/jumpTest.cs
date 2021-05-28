using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpTest : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject go;
    public bool canJump = true;
    public bool canLeft = true;
    public bool canRight = true;
    public float jumpForce = 10.0f;
    public float moveForce = 20.0f;
    public float takeoff = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump") && canJump)
        {
            canJump = false;
            rb.AddForce(transform.up * jumpForce);
        }

        if (Input.GetAxis("Horizontal") < 0 && canLeft)
        {
            if(rb.velocity.x <  0.0f)
            {
                rb.velocity = new Vector2(0.0f, rb.velocity.y);
            } 
            

            rb.AddForce((transform.right * Input.GetAxis("Horizontal")) * Time.deltaTime * moveForce);
        } else if (Input.GetAxis("Horizontal") > 0 && canRight)
        {
            if (rb.velocity.x > 0)
            {
                rb.velocity = new Vector2(0.0f, rb.velocity.y);
            }
            rb.AddForce((transform.right * Input.GetAxis("Horizontal")) * Time.deltaTime * moveForce);
        }

        if ( Input.GetAxis("Vertical") > 0)
        {
            //do something
        } else if (Input.GetAxis("Vertical") < 0)
        {
            // do something else
        }
    }
}
