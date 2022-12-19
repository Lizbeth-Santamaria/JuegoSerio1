using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed=2f;
    public float jumpSpeed=4f;
    Animator animation;

    Rigidbody2D body;
        // Start is called before the first frame update
        void Start()
        {
            body = GetComponent<Rigidbody2D>();
            animation = GetComponent<Animator>();
        }

        // Update is called once per frame
        private void FixedUpdate()
        {
            if(Input.GetKey("a") || Input.GetKey("left"))
                {
                    body.velocity = new Vector2(-speed,body.velocity.y);
                    GetComponent<SpriteRenderer>().flipX = true;
                    animation.SetBool("Run",true);
                }
                else if (Input.GetKey("d") || Input.GetKey("right"))
                {
                    body.velocity = new Vector2(speed,body.velocity.y);
                    GetComponent<SpriteRenderer>().flipX = false;
                    animation.SetBool("Run",true);
                }
                    else
                    {
                        body.velocity = new Vector2(0,body.velocity.y);      
                        animation.SetBool("Run",false);
                    } 
                    if((CheckGround.isGrounded && Input.GetKey("space")) || (CheckGround.isGrounded && Input.GetKey("up")))
                    {
                        body.velocity = new Vector2(body.velocity.x,jumpSpeed);
                    } 
            
        }
}
