using GameTool;
using UnityEngine;
using UnityEngine.U2D;

public class Bird : MonoBehaviour
{
    private float jumpForce = 10f;
    private float cooldown = 0.5f;
    private float spawndelay;
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawndelay = cooldown;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(x:0f, y:jumpForce);
        }

        if (spawndelay <= 0)
        {
            spawndelay = cooldown;
            PoolingManager.Instance.GetObject(NamePrefabPool.Bullet, parent:null, transform.position);
        }
        else
        {
            spawndelay -= Time.deltaTime;
        }
    }
}
