using UnityEngine;

public class LadderTeleport : MonoBehaviour
{
    public Vector2 teleportPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = teleportPosition;
        }
    }
}