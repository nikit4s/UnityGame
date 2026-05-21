using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer sr;

    public GameObject coinPrefab;

	public GameObject slashEffect;
	
	//This is for boss
	private Vector3 originalScale;
	public bool canMove = false;
	public float moveSpeed = 2f;

    // Health
    public int maxHealth = 3;
    private int currentHealth;

    // Attack
    public float attackRange = 1.2f;
    public float attackCooldown = 1.5f;

    private float nextAttackTime;

    private Transform player;
    private Animator animator;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        currentHealth = maxHealth;

        player = GameObject.FindGameObjectWithTag("Player").transform;

        animator = GetComponent<Animator>();

		originalScale = transform.localScale;
    }

    void Update()
{
    if (player == null)
        return;
	// Face player left/right
if (canMove)
{
    if (player.position.x > transform.position.x)
{
    transform.localScale = new Vector3(-Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
}
else
{
    transform.localScale = new Vector3(Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
}
}
    // Boss movement
    if (canMove)
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            player.position,
            moveSpeed * Time.deltaTime
        );
    }

    // Attack logic
    float distance = Vector2.Distance(transform.position, player.position);

    if (distance <= attackRange && Time.time >= nextAttackTime)
    {
        Attack();

        nextAttackTime = Time.time + attackCooldown;
    }
}
	private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        PlayerHealth ph = collision.gameObject.GetComponent<PlayerHealth>();

        if (ph != null)
        {
            ph.TakeDamage(transform.position);
        }
    }
}
    void Attack()
	{
    StartCoroutine(ShowSlash());

    PlayerHealth ph = player.GetComponent<PlayerHealth>();

    if (ph != null)
    	{
        ph.TakeDamage(transform.position);
    	}
	}

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        StartCoroutine(HitAndMaybeDie());
    }
	IEnumerator ShowSlash()
	{
    slashEffect.SetActive(true);

    yield return new WaitForSeconds(0.3f);

    slashEffect.SetActive(false);
	}
    IEnumerator HitAndMaybeDie()
    {
        if (sr != null)
        {
            sr.color = Color.red;

            yield return new WaitForSeconds(0.1f);

            sr.color = Color.white;
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        EnemySpawner spawner = FindFirstObjectByType<EnemySpawner>();

        if (spawner != null)
        {
            spawner.EnemyDied();
        }

        Instantiate(coinPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}