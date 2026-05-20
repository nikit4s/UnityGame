using UnityEngine;

public class Coin : MonoBehaviour
{
    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collected)
            return;

        if (collision.CompareTag("Player"))
        {
            collected = true;

            CoinManager.instance.AddCoin();

            Destroy(gameObject);
        }
    }
}