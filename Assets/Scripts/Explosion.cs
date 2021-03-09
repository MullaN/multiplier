using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public int multiplier = 1;
    Scoring score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Scoring>();
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.name.Contains("Enemy")){
            score.AddToScore(multiplier);
            Destroy(collision.gameObject);
        }
    }
}
