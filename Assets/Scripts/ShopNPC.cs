using UnityEngine;

public class ShopNPC : MonoBehaviour
{
    private bool playerNearby = false;

    public int cost = 5;

    public LadderTeleport ladder;
    public GameObject npcText;

    private void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            CoinManager cm = FindFirstObjectByType<CoinManager>();

            if (cm != null && cm.coins >= cost)
            {
                cm.coins -= cost;
                cm.UpdateUI();

                // Unlock ladder
                ladder.hasUpgrade = true;

                Debug.Log("Upgrade bought!");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerNearby = true;
            npcText.SetActive(true);
            Debug.Log("Press E to buy upgrade");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerNearby = false;
            npcText.SetActive(false);
        }
    }
}