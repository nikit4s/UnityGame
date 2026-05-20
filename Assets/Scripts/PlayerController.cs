using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private Transform shootPoint;

    private Vector2 lastDirection = Vector2.right;

    void Update()
    {
        // Movement input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);
        
        // Flip player sprite
        if (moveX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        // Move player
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Save last movement direction
        if (movement != Vector2.zero)
        {
            lastDirection = movement.normalized;
        }

        // Shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        Vector3 offset = Vector3.zero;

        if (lastDirection == Vector2.right)
            offset = new Vector3(0.5f, 0, 0);

        else if (lastDirection == Vector2.left)
            offset = new Vector3(-0.5f, 0, 0);

        else if (lastDirection == Vector2.up)
            offset = new Vector3(0, 0.5f, 0);

        else if (lastDirection == Vector2.down)
            offset = new Vector3(0, -0.5f, 0);

        Vector3 spawnPos = transform.position + offset;
        spawnPos.z = 0f;

        GameObject arrow = Instantiate(arrowPrefab, spawnPos, Quaternion.identity);

        Arrow arrowScript = arrow.GetComponent<Arrow>();

        if (arrowScript != null)
        {
            arrowScript.SetDirection(lastDirection);
        }
    }
}