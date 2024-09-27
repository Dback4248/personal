using UnityEngine;

public class Play : MonoBehaviour
{
    private new Rigidbody2D rigidbody;

    public float moveSpeed = 8f;

    private void    Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }



}
