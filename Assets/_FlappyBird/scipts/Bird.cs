using UnityEngine;

public class Bird : MonoBehaviour
{
    private float jumpForce = 10f;
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(x:0f, y:jumpForce);
        }
    }
}
