using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // List of player color game objects and the current player
    public List<GameObject> playerColor;
    private GameObject currentPlayer;
    private int currentPlayerIndex = 0;

    // Range for enemy detection and the enemy tag
    public float detectionRange = 15;
    public string enemyTag = "Enemy";

    void Awake()
    {
        // Initialize the current player to the first player color
        currentPlayer = playerColor[currentPlayerIndex++];
    }

    void Update()
    {
        // Check for the "Fire1" button input to change player color
        if (Input.GetButtonDown("Fire1"))
        {
            ChangePlayerColor();
        }

        // Find all game objects with the specified enemy tag
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        foreach (GameObject enemy in enemies)
        {
            // Calculate the distance between this object and the current enemy
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

            // If the enemy is within the detection range, rotate towards it
            if (distanceToEnemy <= detectionRange)
            {
                Vector3 relativePosition = enemy.transform.position - transform.position;
                Quaternion rotation = Quaternion.LookRotation(relativePosition, Vector3.up);
                transform.rotation = rotation;
            }
        }
    }

    public void ChangePlayerColor()
    {
        // Deactivate the current player, switch to the next player color
        currentPlayer.SetActive(false);
        currentPlayer = playerColor[currentPlayerIndex++];

        // Reset the index if it exceeds the number of player colors
        if (currentPlayerIndex == playerColor.Count)
        {
            currentPlayerIndex = 0;
        }

        // Activate the new player color
        currentPlayer.SetActive(true);
    }

    // Handle collisions with enemies
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject);       // Destroy this player
        }
    }

    // Draw a gizmo representation of the detection range
    private void OnDrawGizmos()
    {
        float radius = detectionRange;
        float angleStep = 360f / 360;
        Gizmos.color = Color.white;

        for (int i = 0; i < 360; i++)
        {
            float angle = i * angleStep;
            Vector3 position = transform.position + radius * Vector3.right * Mathf.Cos(angle) + radius * Vector3.forward * Mathf.Sin(angle);
            Gizmos.DrawLine(position, position + Vector3.right * 0.1f);
        }
    }
}
