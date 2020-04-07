using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class HeroMovement : MonoBehaviour
{
    
    
    public float default_gravity_value;
    public float default_jump_force_value;
    public float speed_value;
    float gravity_value;
    float current_jump_force_value=0;
    
    public void Update()
    {
        //////////////////////////////// HORIZONTAL MOVEMENT IMPLEMENTATION ///////////////////////////////////////////// 

        float horizontal_momevent_direction = Input.GetAxis("Horizontal");  
        Vector3 horizontal_motion_vector = new Vector3(speed_value*horizontal_momevent_direction, 0.0f, 0.0f) * Time.deltaTime;
        transform.position = transform.position + horizontal_motion_vector;

        ///////////////////////////////////// GRAVITY IMPLEMENTATION ////////////////////////////////////////////////////
                
        Vector3 gravity_motion_vector = new Vector3(0.0f, gravity_value, 0.0f) * Time.deltaTime;
        transform.position = transform.position + gravity_motion_vector;
        
        if (transform.position.y <= 0f)
        {
            gravity_value = 0;
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else
        {
            gravity_value -= 0.5f; 
        }

        //////////////////////////////////// JUMPING IMPLEMENTATION  ////////////////////////////////////////////////////
        
        Vector3 jump_direction_vector = new Vector3(0.0f, current_jump_force_value, 0.0f) * Time.deltaTime;
        transform.position = transform.position + jump_direction_vector;
        if (current_jump_force_value > 0f)
        {
            current_jump_force_value -= 2f; 
        }
        else
        {
            current_jump_force_value = 0f;
        }
        if (Input.GetButtonDown("Jump") && transform.position.y <= 0f)
        {
            current_jump_force_value = default_jump_force_value;
        }
    }
} 