﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float spawnTime = 6f;
    [SerializeField] GameObject enemy;

    private Vector2 spawnPosition;

    private int corner = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
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

        if (corner == 3) {
            corner = 0;
        } else {
            corner++;
        }
    }
}
