using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Update()
    {
        // Get input
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Create movement vector
        Vector3 movement = new Vector3(moveX, moveY, 0 );

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}