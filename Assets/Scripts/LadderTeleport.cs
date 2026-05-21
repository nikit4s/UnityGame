using UnityEngine;

public class LadderTeleport : MonoBehaviour
{
    public Vector2 teleportPosition;

    public bool hasUpgrade = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && hasUpgrade)
        {
            collision.transform.position = teleportPosition;
        }
    }
}