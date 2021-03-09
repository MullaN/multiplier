using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] multipliers;

    [SerializeField] float spawnTime = 3f;

    private float timer = 0f;

    Player player;

    private Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        spawnPosition.z = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime){
            spawnPosition.y = Random.Range(-4f, 4f);
            if (player.transform.position.x >= 0 && player.transform.position.y <= 0){
                if (spawnPosition.y < 0){
                    spawnPosition.x = Random.Range(-8f, 0f);
                } else {
                    Random.Range(-8f, 8f);
                }
            } else if (player.transform.position.x >= 0 && player.transform.position.y >= 0){
                if (spawnPosition.y > 0){
                    spawnPosition.x = Random.Range(-8f, 0f);
                } else {
                    Random.Range(-8f, 8f);
                }
            } else if (player.transform.position.x <= 0 && player.transform.position.y <= 0){
                if (spawnPosition.y < 0){
                    spawnPosition.x = Random.Range(0f, 8f);
                } else {
                    Random.Range(-8f, 8f);
                }
            } else {
                if (spawnPosition.y > 0){
                    spawnPosition.x = Random.Range(0f, 8f);
                } else {
                    Random.Range(-8f, 8f);
                }
            }
            Instantiate(multipliers[Random.Range(0,3)],spawnPosition, Quaternion.identity);
            timer = 0;
        }
    }
}
