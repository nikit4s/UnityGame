using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public Image[] hearts;

    private int currentHealth;

    public float knockbackForce = 16f;

    private bool invincible = false;

    private SpriteRenderer sr;

    void Start()
    {
        currentHealth = hearts.Length;

        sr = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(Vector2 enemyPosition)
    {
        if (invincible)
            return;

        StartCoroutine(HitFlash());

        currentHealth--;

        if (currentHealth >= 0)
        {
            hearts[currentHealth].enabled = false;
        }

        // Knockback
        Vector2 knockDir =
            (transform.position - (Vector3)enemyPosition).normalized;

        StartCoroutine(Knockback(knockDir));

        StartCoroutine(InvincibilityFrames());

        if (currentHealth <= 0)
        {
            Debug.Log("Player Dead");
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

    IEnumerator Knockback(Vector2 direction)
    {
        float duration = 0.2f;
        float timer = 0f;

        while (timer < duration)
        {
            transform.position +=
                (Vector3)(direction * knockbackForce * Time.deltaTime);

            timer += Time.deltaTime;

            yield return null;
        }
    }

    IEnumerator InvincibilityFrames()
    {
        invincible = true;

        yield return new WaitForSeconds(1f);

        invincible = false;
    }
}