using UnityEngine;


public class MovemenrPM : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, keyCode = KeyCode.E;
    public float speed = 10, jumpHeight = 15, maxspeed = 10;
    
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb =  GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey() is for HOLDING a key
        //Input.GetKey() is for PRASSING a Key
        //Input.GetKey() is for RELESING a key



        if (Input.GetKey(KeyCode.A))    //Check for the player HOLDING DOWN the left button
        {
            // Get the GameObject's RigigBody2D component and set its velocity to the left at given speed
            _rb.velocity = Vector2.left;
        {


        if (Input.GetKey(KeyCode.D))    //Check for the player HOLDING DOWN the left button
        {
            // Get the GameObject's RigigBody2D component and set its velocity to the right at given speed
            _rb.AddForce(Vector2.right * speed * Time.deltaTime);

        }
        
}
        if (Input.GetKey(KeyCode.A))    //Check for the player HOLDING DOWN the left button
        {
            // Get the GameObject's RigigBody2D component and set its velocity to the left at given speed
             _rb.velocity = Vector2.left * speed;
        }
 