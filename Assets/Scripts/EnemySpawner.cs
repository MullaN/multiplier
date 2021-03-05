using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float startSpawnTime = 3f;
    [SerializeField] GameObject enemy = null;

    private Vector2 spawnPosition;

    private int corner = 0;

    private float timer = 0f;

    private int totalEnemies = 0;

    private float currentSpawnTime;
    
    private bool decreasedSpawnTimeOnLast = false;

    // Start is called before the first frame update
    void Start()
    {
        currentSpawnTime = startSpawnTime;
    }

    void Update() {
        timer += Time.deltaTime;
        if (timer > currentSpawnTime){
            Spawn();
            timer = 0f;
            if (totalEnemies % 10 == 0 && currentSpawnTime > 0.4f){
                currentSpawnTime *= 0.9f;
                currentSpawnTime = Mathf.Clamp(currentSpawnTime, 0.4f, startSpawnTime);
            }
        }
    }

    // Update is called once per frame
    void Spawn()
    {
        spawnPosition.x = 9f;
        spawnPosition.y = 4f;

        if (corner < 2){
            spawnPosition.x *= -1;
        }

        if (corner % 2 > 0){
            spawnPosition.y *= -1;
        }

        Instantiate(enemy, spawnPosition, Quaternion.identity);

        totalEnemies++;

        if (corner == 3) {
            corner = 0;
        } else {
            corner++;
        }
    }
}
