using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimesBehaviour : MonoBehaviour
{
    [SerializeField] Explosion explosionObject;
    [SerializeField] int multiplicationAmount;
    Explosion explosion;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 9f);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.name.Contains("Player")){
            explosion = Instantiate(explosionObject, transform.position, Quaternion.identity);
            explosion.multiplier = multiplicationAmount;
            Destroy(gameObject);
        }
    }
}
