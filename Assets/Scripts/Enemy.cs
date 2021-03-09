using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float startSpeed = 0.1f;

    // Scoring score;
    
    // Start is called before the first frame update
    void Start()
    {
        // score = FindObjectOfType<Scoring>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, FindObjectOfType<Player>().transform.position, startSpeed * Time.deltaTime);
    }

    // private void OnCollisionEnter2D(Collision2D collision){
    //     if (collision.gameObject.name.Contains("Explosion")){
    //         score.AddToScore();
    //         Destroy(gameObject);
    //     }
    // }
}
