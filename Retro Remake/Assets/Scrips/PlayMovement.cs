using UnityEngine;

public class PlayMovement : MonoBehaviour
{
    private new Camera camera;
    private new Rigidbody2D rigidbody;

    private Vector2 velocity;

    public PlayMovement(float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }

    public float moveSpeed = 8f;
    public float maxJumpHeight = 5f;
    public float maxJumpTime = 1f;
   
    public float JumpForce => (2f * maxJumpHeight) / (maxJumpTime / 2f);
    public float Gravity => (-2f * maxJumpHeight) / Mathf.Pow((maxJumpTime / 2f), 2f);

    public bool Grounded { get; private set; }
    private float inputAxis;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    private void Update()
    {
        HorizontalMovement(); 
    }

    private void HorizontalMovement()
    {
        inputAxis = Input.GetAxis("Horizontal");
        velocity.x = Mathf.MoveTowards(velocity.x, inputAxis * moveSpeed, moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector2 position  = rigidbody.position;
        position += velocity * Time.fixedDeltaTime;

        Vector2 leftEdge  = camera.ScreenToWorldPoint(Vector2.zero);
        Vector2 rightEdge = camera.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        position.x = Mathf.Clamp(position.x, leftEdge.x + 0.5f, rightEdge.x - 0.5f);

        rigidbody.MovePosition(position);
    }
}
