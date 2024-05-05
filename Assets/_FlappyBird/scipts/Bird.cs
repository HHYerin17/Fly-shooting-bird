using GameTool;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private float jumpForce = 10f;
    private float cooldown = 0.5f;
    private float boundTop = 4.2f;
    private float boundBot = -4.3f;
    private float spawnDelay;
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnDelay = cooldown;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(x:0f, y:jumpForce);
        }

        if (transform.position.y >= boundTop) transform.position = new Vector2(transform.position.x, boundTop);
        if (transform.position.y <= boundBot) transform.position = new Vector2(transform.position.x, boundBot);

        if (spawnDelay <= 0)
        {
            spawnDelay = cooldown;
            PoolingManager.Instance.GetObject(NamePrefabPool.Bullet, parent:null, transform.position).Disable(2f);
        }
        else
        {
            spawnDelay -= Time.deltaTime;
        }
    }
}
