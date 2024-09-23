using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemenrPM : MonoBehaviour
{
    public KeyCode left =  KeyCode.A, right = KeyCode.D, = 
    public float speed = 10;
    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb =  GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey() is for HOLDING a key
        //Input.GetKey() is for PASSING a Key
        //Input.GetKey() is for RELE
        
        
        
        if (Input.GetKey(KeyCode.A))    //Check for the player HOLDING DOWN the left button
        {
            // Get the GameObject's RigigBody2D component and set its velocity to the left at given speed
            _rb.velocity = Vector2. * left;
        {


        if (Input.GetKey(KeyCode.D))    //Check for the player HOLDING DOWN the left button
        {
            // Get the GameObject's RigigBody2D component and set its velocity to the left at given speed
            _rb.velocity = Vector2.right * speed;

        }
        
}
        if (Input.GetKey(KeyCode.A))    //Check for the player HOLDING DOWN the left button
        {
                // Get the GameObject's RigigBody2D component and set its velocity to the left at given speed
                _rb.velocity = Vector2.* left;
                {


        if (Input.GetKey(KeyCode.D))    //Check for the player HOLDING DOWN the left button
                {
                   // Get the GameObject's RigigBody2D component and set its velocity to the left at given speed
                        _rb.velocity = Vector2.right * speed;

                    }

                    