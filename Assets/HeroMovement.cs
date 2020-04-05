using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class HeroMovement : MonoBehaviour
{
    //(посмотри, сначала я ввожу default_jump_force_value(присваиваю значение в редакторе), затем current_jump_force_value. Произвожу какие-то действия с current_jump_force_value, а затем мне нужно чтобы значение переменной стало дефолтным. И без default_jump_force_value я хз как это сделать.
    // ------------------------------------|- \
    public float default_gravity_value;//    |   --     КАК ИЗБЕЖАТЬ           ТАКИХ
    public float default_jump_force_value;// |   --                  ВВЕДЕНИЯЕ        ПЕРЕМЕННЫХ?
    // ------------------------------------|- / 
    public float speed_value;
    float gravity_value;
    

    float current_jump_force_value=0;
    
    public void Update()
    {   // Каждую фичу (ходьба, гравитация, прыжок) я поделил на "модули" (вектор, что_делает_фича, доп_условия). Это нормально или сначала прописывают векторы, потом логику, потом доп условия? 
        //////////////////////////////// HORIZONTAL MOVEMENT IMPLEMENTATION ///////////////////////////////////////////// 

        float horizontal_momevent_direction = Input.GetAxis("Horizontal");  // -1...+1
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
            gravity_value -= 0.5f; //Подобрал экспериментально. 
        }

        //////////////////////////////////// JUMPING IMPLEMENTATION  ////////////////////////////////////////////////////
        
        Vector3 jump_direction_vector = new Vector3(0.0f, current_jump_force_value, 0.0f) * Time.deltaTime;
        transform.position = transform.position + jump_direction_vector;
        if (current_jump_force_value > 0f)
        {
            current_jump_force_value -= 2f; //Подобрал экспериментально.
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