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
    
    private Vector2[] spawnPositions = new Vector2[5];

    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        currentSpawnTime = startSpawnTime;
        spawnPositions[0].x = 9.4338f;
        spawnPositions[0].y = 4.5158f;
        spawnPositions[1].x = 9.259f;
        spawnPositions[1].y = 4.623309f;
        spawnPositions[2].x = 9.461791f;
        spawnPositions[2].y = 4.7141f;
        spawnPositions[3].x = 9.453879f;
        spawnPositions[3].y = 4.9114f;
        spawnPositions[4].x = 9.6567f;
        spawnPositions[4].y = 4.805287f;
    }

    void Update() {
        timer += Time.deltaTime;
        if (timer > currentSpawnTime){
            if (player.transform.position.x >= 0 && player.transform.position.y <= 0){
                corner = 0;
            } else if (player.transform.position.x >= 0 && player.transform.position.y >= 0){
                corner = 1;
            } else if (player.transform.position.x <= 0 && player.transform.position.y <= 0){
                corner = 2;
            } else {
                corner = 3;
            }
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
        for (int i = 0; i < 5; i++){
            spawnPosition.x = spawnPositions[i].x;
            spawnPosition.y = spawnPositions[i].y;

            if (corner < 2){
                spawnPosition.x *= -1;
            }

            if (corner % 2 > 0){
                spawnPosition.y *= -1;
            }

            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }

        totalEnemies++;
    }
}
