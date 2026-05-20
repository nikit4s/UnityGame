using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;

    public float spawnRate = 3f;
    public int maxEnemies = 5;

    private int currentEnemies = 0;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        // Stop spawning if limit reached
        if (currentEnemies >= maxEnemies)
            return;

        if (spawnPoints.Length == 0)
            return;

        int index = Random.Range(0, spawnPoints.Length);

        GameObject enemy = Instantiate(
            enemyPrefab,
            spawnPoints[index].position,
            Quaternion.identity
        );

        currentEnemies++;
    }

    // Call this when enemy dies
    public void EnemyDied()
    {
        currentEnemies--;

        if (currentEnemies < 0)
            currentEnemies = 0;
    }
}