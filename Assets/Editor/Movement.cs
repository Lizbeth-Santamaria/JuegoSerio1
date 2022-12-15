using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed=2f;
    public float jumpSpeed=4f;

    Rigidbody2D body;
        // Start is called before the first frame update
        void Start()
        {
            body = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        private void FixedUpdate()
        {
            if(Input.GetKey("a") || Input.GetKey("left"))
                {
                    body.velocity = new Vector2(-speed,body.velocity.y);
                }
                else if (Input.GetKey("d") || Input.GetKey("right"))
                {
                    body.velocity = new Vector2(speed,body.velocity.y);
                }
                    else
                    {
                        body.velocity = new Vector2(0,body.velocity.y);      
                    } 
                    if(CheckGround.isGrounded && Input.GetKey("space"))
                    {
                        body.velocity = new Vector2(body.velocity.x,jumpSpeed);
                    } 
            
        }
}
