using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    private Rigidbody2D rb;
   
    // Start is called before the first frame update
    public void Start()
    {
    




    }

    // Update is called once per frame
    public void Update()

    {
        var position = Input.GetAxis("Horizontal");
        float movementSpeed = 3;

        switch (position)
        {
            case position.:
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
            case position > 0:
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
        
        
        //if (position < 0)
        //{ transform.Translate(Vector3.left * movementSpeed * Time.deltaTime); }
        //else if (position > 0)
        //{ transform.Translate(Vector3.right * movementSpeed * Time.deltaTime); }

        

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        //}
        
        
        
        
        
        
        
        //}
        //if (Input.GetButtonDown("UpArrow")) 
        //{
        //    rb.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 3f), ForceMode2D.Impulse);
        //    Input.GetAxis("Horizontal");
        //}

        //float horizontal = Input.GetAxis("Horizontal")*5;
        //float vertical = Input.GetAxis("Vertical") * 5;
        //Debug.Log(horizontal);
        //HandleMovement(horizontal);
        //jump();
        //HandleMovement(vertical);
        //if (horizontal < 0)
        //{
        //m_FacingRight = false;
        //transform.localRotation = Quaternion.Euler(0, 180, 0);
        //}
        //else
        //{
        //m_FacingRight = true;
        //transform.localRotation = Quaternion.Euler(0, 0, 0);
        //}


    }
    //private void HandleMovement(float horizontal)
    //{
    //myRigidbody.velocity = new Vector2(horizontal, myRigidbody.velocity.y);
    //myRigidbody.velocity = new Vector2(vertical, myRigidbody.velocity.y);
    //}
    //void jump()
    //{
    //if (Input.GetButtonDown("Jump"))
    //{
    //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 3f), ForceMode2D.Impulse);
    //}

    //}

}


