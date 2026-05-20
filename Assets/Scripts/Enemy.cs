using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer sr;
    public GameObject coinPrefab;

    public int maxHealth = 3;
    private int currentHealth;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        StartCoroutine(HitAndMaybeDie());
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

    IEnumerator HitFlash()
    {
        if (sr != null)
        {
            sr.color = Color.red;

            yield return new WaitForSeconds(0.1f);

            sr.color = Color.white;
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

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Arrow"))
        {
            TakeDamage(1);
        }
    }*/
}