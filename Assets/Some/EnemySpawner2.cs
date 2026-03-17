using System.Collections;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;

    public float spawnInterval = 2f;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            SpawnEnemyVariant();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnEnemyVariant()
    {
        GameObject prefabToSpawn;

        if (Random.value > 0.5f)
        {
            prefabToSpawn = enemyPrefab1;
        }
        else
        {
            prefabToSpawn = enemyPrefab2;
        }

        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
    }
}