using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_logic : MonoBehaviour
{
    public GameObject enemy; 
    public float xValue = -10;
    public float yValue = 10;
    private int i;
    void Update()
    {
            Vector2 randomSpawnPosition = new Vector2(Random.Range(xValue,yValue),Random.Range(xValue, yValue + 1));
            Instantiate(enemy, randomSpawnPosition, Quaternion.identity);
    }
}
