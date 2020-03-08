using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public float gravity = -0.5f;
    public float jumppower = 3f;
    public float JumpTimer = 1;
    public void Start()
    {
    
    }
    public void Update()

{
    var position = Input.GetAxis("Horizontal");
    transform.position = transform.position + new Vector3(position, gravity, 0)*Time.deltaTime;

        if (JumpTimer > 0 && Input.GetButton("Jump"))
        {
            JumpTimer -= Time.deltaTime;
            transform.position = transform.position + new Vector3(0, jumppower, 0) * Time.deltaTime;
        }
        else 
            JumpTimer = 1 ;
        transform.position = transform.position + new Vector3(0, gravity, 0) * Time.deltaTime;
    }    
    

}


