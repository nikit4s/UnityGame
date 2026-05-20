using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 1f;

    public AudioClip wallHitSound;
    public AudioClip enemyHitSound;

    private Vector2 moveDirection;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += (Vector3)(moveDirection * speed * Time.deltaTime);
    }

    public void SetDirection(Vector2 direction)
    {
        moveDirection = direction.normalized;

        float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            // Play enemy sound
            if (enemyHitSound != null)
                AudioSource.PlayClipAtPoint(enemyHitSound, transform.position);

            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(1);
            }

            Destroy(gameObject);
        }

        else if (collision.CompareTag("Wall"))
        {
            // Play wall sound
            if (wallHitSound != null)
                AudioSource.PlayClipAtPoint(wallHitSound, transform.position);

            Destroy(gameObject);
        }
    }
}