using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public Vector2 spawnTime = new Vector2(3,10);
    public float xValue = -10;
    public float yValue = 10;
    private int i;

    private void Start()
    {
        spawnEnemy();
    }

    void Update()
    {

    }

    private void spawnEnemy()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(xValue, yValue), Random.Range(xValue, yValue + 1));
        Instantiate(enemy, randomSpawnPosition, Quaternion.identity);

        Invoke(
            nameof(spawnEnemy),
            Random.Range(spawnTime.x, spawnTime.y)
        );

    }


}
