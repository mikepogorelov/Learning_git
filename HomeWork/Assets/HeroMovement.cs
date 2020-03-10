using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public float gravity = 0.5f;
    public float jumpSpeed = 3f;
    public float JumpTimer = 1;
    public void Start()
    {
    
    }
    public void Update()

{
    var position = Input.GetAxis("Horizontal");
    transform.position = transform.position + new Vector3(position, -gravity, 0)*Time.deltaTime;

        if (transform.position.y <= -1.5)
        {
            gravity = 0;
        }
        
        
        if ( Input.GetButton("Jump")) //jumpSpeed > gravity &&
        {
            gravity = 0.5f;
            JumpTimer -= Time.deltaTime;
            transform.position = transform.position + new Vector3(0, jumpSpeed, 0) * Time.deltaTime;
            
        }
        //else
        //    JumpTimer = 1; 
        //transform.position = transform.position + new Vector3(0, gravity, 0) * Time.deltaTime;

        //while (JumpTimer >= 0 && Input.GetButton("Jump"))
        //{
        //    JumpTimer -= Time.deltaTime;
        //    transform.position = transform.position + new Vector3(0, jumpSpeed, 0) * Time.deltaTime;

        //}


    }    
    

}


